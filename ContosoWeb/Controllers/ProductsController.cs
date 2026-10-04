using Microsoft.AspNetCore.Mvc;

namespace ContosoWeb.Controllers
{
    [ApiController]
    [Route("Products")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Products";
        }

        [HttpGet("Details/{id}")]
        public string Details(int id)
        {
            return $"Product Details: {id}";
        }

        [HttpGet("Details")]
        public string Details()
        {
            return "Product Details";
        }

        [HttpGet("Count")]
        public string Count()
        {
            return "Product Count";
        }
    }
}