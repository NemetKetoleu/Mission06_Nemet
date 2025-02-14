using System.ComponentModel.DataAnnotations;

namespace Mission06_Nemet.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int Category { get; set; } // Store category as an integer

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool? Edited { get; set; }

        public string? LentTo { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
