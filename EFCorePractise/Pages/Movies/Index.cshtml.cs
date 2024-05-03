using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EFCorePractise.Data;
using EFCorePractise.Models;

namespace EFCorePractise.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly EFCorePractise.Data.MovieContext _context;

        public IndexModel(EFCorePractise.Data.MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
