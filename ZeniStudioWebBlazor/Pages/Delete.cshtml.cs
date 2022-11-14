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
    public class DeleteModel : PageModel
    {
        private readonly ZeniStudioWebBlazor.Data.ApplicationDbContext _context;

        public DeleteModel(ZeniStudioWebBlazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Proyect Proyect { get; set; }

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null || _context.Proyect == null)
            {
                return NotFound();
            }

            var proyect = await _context.Proyect.FirstOrDefaultAsync(m => m.CodigoProyecto == id);

            if (proyect == null)
            {
                return NotFound();
            }
            else 
            {
                Proyect = proyect;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Proyect == null)
            {
                return NotFound();
            }
            var proyect = await _context.Proyect.FindAsync(id);

            if (proyect != null)
            {
                Proyect = proyect;
                _context.Proyect.Remove(Proyect);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
