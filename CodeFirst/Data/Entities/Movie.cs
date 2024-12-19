using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Data.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Title cannot exced 100 characters.")]
        public string Title { get; set; }

        [Required]
        [StringLength(35, ErrorMessage = "Genre cannot exceed 35 characters.")]
        public string Genre { get; set; }

        [Required]
       
        public int ReleaseYear { get; set; }
    }
}
