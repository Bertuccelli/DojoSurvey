using Microsoft.AspNetCore.Mvc;
namespace Survey.Controllers;

public class HomeController : Controller {
    [HttpGet("")]

    public ViewResult Index() {
        return View();
    }

    [HttpPost("results")]
    public IActionResult Results(string name, string comments, string language, string location ){
        ViewBag.name = name;
        ViewBag.comments = comments;
        ViewBag.language = language;
        ViewBag.location = location;
        return View();
    }

}