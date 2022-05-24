using MVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            var productModel = new ProductModel();
            ViewBag.products = productModel.findAll();
            return View();
        }
    }
}
