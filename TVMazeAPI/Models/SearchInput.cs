using System.ComponentModel.DataAnnotations;

namespace TVMazeAPI.Models;

public class SearchInput
{
    [Required(ErrorMessage = "Enter a show name")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Search must be between 2 and 100 Characters")]
    public string Query { get; set; } = "";
}