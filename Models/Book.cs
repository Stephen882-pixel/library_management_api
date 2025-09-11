using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementAPI.Models;

public class Book
{
    [Table("books")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(200)]
    public String Title { get; set; } =  string.Empty;
    
    [Required]
    [MaxLength(100)]
    public String Author { get; set; } =  string.Empty;
    
    [Required]
    [MaxLength(20)]
    public String ISBN { get; set; } = String.Empty;
    
    [Range(1000,9999)]
    public int PublicationYear { get; set; }
    
    [MaxLength(50)]
    public String Genre { get; set; } = String.Empty;

    public bool IsAvailable { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}