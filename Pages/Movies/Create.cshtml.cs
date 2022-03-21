#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesLoraine.Data;
using RazorPagesLoraine.Models;

namespace RazorPagesLoraine.Pages.Movies
{
#pragma warning disable 8618
#pragma warning disable 8602
    public class CreateModel : PageModel
    {
        private readonly RazorPagesLoraine.Data.RazorPagesLoraineContext _context;

        public CreateModel(RazorPagesLoraine.Data.RazorPagesLoraineContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
#pragma warning restore 8618
#pragma warning restore 8602
}
