using System.ComponentModel.DataAnnotations;

namespace ComicSystem.Models
{
    public class ComicBook
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }
    }
}
