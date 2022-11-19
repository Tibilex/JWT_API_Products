using Microsoft.AspNetCore.Mvc;

namespace JWT_API_Products.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
