using Microsoft.AspNetCore.Mvc;
namespace Survey.Controllers;

public class HomeController : Controller {
    [HttpGet("")]

    public ViewResult Survey() {
        return View();
    }

    [HttpPost("results")]
    public IActionResult Results(SurveyResults results){
        if(ModelState.IsValid){
            return View("Index", results);
        }
        else {
            return View("Survey");
        }
    }
    public IActionResult Privacy() {
        return View();
    }

}