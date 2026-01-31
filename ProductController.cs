using Microsoft.AspNetCore.Mvc;
using ProductCatalog.BusinessLogic;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        ProductBL productBL = new ProductBL();

        public IActionResult ShowAll()
        {
            var products = productBL.GetAllProducts();
            return View(products);
        }

        public IActionResult ShowById(int id)
        {
            var product = productBL.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
