using Microsoft.AspNetCore.Mvc;

namespace BE_DOANCOSO.Controllers;

public class ProductController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}