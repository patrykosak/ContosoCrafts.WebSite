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
    public class DetailsModel : PageModel
    {
        private readonly ContosoCrafts.WebSite.Data.ProductsContext _context;

        public DetailsModel(ContosoCrafts.WebSite.Data.ProductsContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.products.FirstOrDefaultAsync(m => m.Id == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
