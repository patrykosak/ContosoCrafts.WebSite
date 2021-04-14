using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Data;
using ContosoCrafts.WebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoCrafts.WebSite
{
    public class GetFromDBModel : PageModel
    {
        private readonly ProductsContext _context;
        public IList<Product> Products;
        public GetFromDBModel(ProductsContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Products = _context.products.ToList();
        }
    }
}