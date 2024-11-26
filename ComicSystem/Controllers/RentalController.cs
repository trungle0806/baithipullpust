public class RentalsController : Controller
{
    private readonly ApplicationDbContext _context;

    public RentalsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Hiển thị danh sách các giao dịch cho thuê sách
    public async Task<IActionResult> Index()
    {
        var rentals = await _context.Rentals.Include(r => r.Customer).ToListAsync();
        return View(rentals);
    }

    // Hiển thị form tạo giao dịch cho thuê sách
    public IActionResult Create()
    {
        return View();
    }

    // Xử lý tạo giao dịch cho thuê sách
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("CustomerId,RentalDate,ReturnDate")] Rental rental)
    {
        if (ModelState.IsValid)
        {
            _context.Add(rental);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(rental);
    }

    // Báo cáo cho thuê sách
    public IActionResult Report(DateTime startDate, DateTime endDate)
    {
        var rentalReport = _context.Rentals
            .Where(r => r.RentalDate >= startDate && r.ReturnDate <= endDate)
            .Include(r => r.Customer)
            .Include(r => r.RentalDetails)
            .ThenInclude(rd => rd.ComicBook)
            .ToList();

        return View(rentalReport);
    }
}
