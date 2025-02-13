using System.ComponentModel.DataAnnotations;

namespace MyLibraryWebsite.Views.ViewModels;

public class BookViewModel
{
    [Required]
    public string Name { get; set; } = "";
    [Required]
    public string Author { get; set; } = "";
    [Required]
    public int Quantity { get; set; } = 0;
    [Required]
    public bool IsBorrowed { get; set; } = false;
}
