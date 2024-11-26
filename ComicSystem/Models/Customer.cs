using System.ComponentModel.DataAnnotations;

namespace ComicSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
