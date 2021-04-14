using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoCrafts.WebSite.Data;
using ContosoCrafts.WebSite.Models;

namespace ContosoCrafts.WebSite
{
    public class IndexModel : PageModel
    {
        private readonly ContosoCrafts.WebSite.Data.ProductsContext _context;

        public IndexModel(ContosoCrafts.WebSite.Data.ProductsContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.products.ToListAsync();
        }
    }
}
