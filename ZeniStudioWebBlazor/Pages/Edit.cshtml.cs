using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZeniStudioWebBlazor.Data;

namespace ZeniStudioWebBlazor.Pages
{
    public class EditModel : PageModel
    {
        private readonly ZeniStudioWebBlazor.Data.ApplicationDbContext _context;

        public EditModel(ZeniStudioWebBlazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Proyect Proyect { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(String? id)
        {
            if (id == null || _context.Proyect == null)
            {
                return NotFound();
            }

            var proyect =  await _context.Proyect.FirstOrDefaultAsync(m => m.CodigoProyecto == id);
            if (proyect == null)
            {
                return NotFound();
            }
            Proyect = proyect;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Proyect).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProyectExists(Proyect.CodigoProyecto))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProyectExists(string id)
        {
          return _context.Proyect.Any(e => e.CodigoProyecto == id);
        }
    }
}
