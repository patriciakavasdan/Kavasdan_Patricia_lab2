using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kavasdan_Patricia_lab2.Data;
using Kavasdan_Patricia_lab2.Models;

namespace Kavasdan_Patricia_lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Kavasdan_Patricia_lab2.Data.Kavasdan_Patricia_lab2Context _context;

        public IndexModel(Kavasdan_Patricia_lab2.Data.Kavasdan_Patricia_lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
