using System.ComponentModel.DataAnnotations;

namespace ComicSystem.Models
{
    public class Rental
    {
        public int Id { get; set; }

        [Required]
        public DateTime RentalDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
