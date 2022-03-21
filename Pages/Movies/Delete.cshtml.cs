#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesLoraine.Data;
using RazorPagesLoraine.Models;

namespace RazorPagesLoraine.Pages.Movies
{
#pragma warning disable 8618
#pragma warning disable 8601
#pragma warning disable 8602
#pragma warning disable 8604

    public class DeleteModel : PageModel
    {
        private readonly RazorPagesLoraine.Data.RazorPagesLoraineContext _context;

        public DeleteModel(RazorPagesLoraine.Data.RazorPagesLoraineContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FindAsync(id);

            if (Movie != null)
            {
                _context.Movie.Remove(Movie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
#pragma warning restore 8618
#pragma warning restore 8601
#pragma warning restore 8602
#pragma warning restore 8604
}
