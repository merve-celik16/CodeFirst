using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Data.Entities
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Platform cannot exceed 50 characters.")]
        public string Platform { get; set; }

        [Required]
        
        public decimal Rating { get; set; }
    }
}
