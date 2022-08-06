#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurvey.Models;

public class SurveyResults {
    [Required(ErrorMessage = "is required")]
    [MinLength(2, ErrorMessage = "Name must be at least 2 characters!")]
    public string Name {get; set;}
    [Required(ErrorMessage = "is required")]
    public string Location {get; set;}
    [Required(ErrorMessage = "is required")]
    public string Language {get; set;}
    [MinLength(20, ErrorMessage = "Comments must be at least 20 characters!")]
    public string? Comments {get; set;}
}