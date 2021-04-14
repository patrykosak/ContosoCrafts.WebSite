using System.Collections.Generic;
using ContosoCrafts.Services;
using ContosoCrafts.WebSite.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite
{
    public class GetFromFileModel : PageModel
    {
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }
        public GetFromFileModel(JsonFileProductService productService)
        {
            ProductService = productService;
        }
        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}