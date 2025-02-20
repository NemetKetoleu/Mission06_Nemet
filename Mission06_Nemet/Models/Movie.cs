using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Nemet.Models;

public partial class Movie
{
    [Key]
    [Required]
    public int MovieId { get; set; }

    [Required(ErrorMessage = "Enter a valid Movie Title.")]
    public string Title { get; set; } = null!;

    [Required, Range(1888, int.MaxValue, ErrorMessage = "Year must be 1888 or later.")]
    public int Year { get; set; }

    public string? Director { get; set; }

    public string? Rating { get; set; }

    [Required(ErrorMessage = "The Edited status is required.")]
    public int Edited { get; set; }

    public string? LentTo { get; set; }

    [Required(ErrorMessage = "The CopiedToPlex status is required.")]
    public int CopiedToPlex { get; set; }

    public string? Notes { get; set; }

    [ForeignKey("CategoryId")]
    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }
}
