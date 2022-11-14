using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ZeniStudioWebBlazor.Data;

namespace ZeniStudioWebBlazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ZeniStudioWebBlazor.Data.ApplicationDbContext _context;

        public IndexModel(ZeniStudioWebBlazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Proyect> Proyect { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Proyect != null)
            {
                Proyect = await _context.Proyect.ToListAsync();
            }
        }
    }
}
