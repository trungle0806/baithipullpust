using System.ComponentModel.DataAnnotations;

namespace ComicSystem.Models
{
    public class RentalDetail
    {
        public int Id { get; set; }

        [Required]
        public int RentalId { get; set; }

        public Rental Rental { get; set; }

        [Required]
        public int ComicBookId { get; set; }

        public ComicBook ComicBook { get; set; }

        [Required]
        public int Quantity { get; set; }

        public decimal PricePerDay { get; set; }
    }
}
