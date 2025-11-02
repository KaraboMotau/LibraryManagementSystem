using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryManagementSystem.Pages.Manage
{
    public class IndexModel : PageModel
    {
        private readonly LibraryManagementSystem.Data.ApplicationDbContext _context;

        public IndexModel(LibraryManagementSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Book> Books { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Titles { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? BookTitle { get; set; }

        public async Task OnGetAsync()
        {
            /* if (_context.Books != null)
             {
                 Books = await _context.Books.ToListAsync();
             }*/
            
            IQueryable<string> genreQuery = from m in _context.Books
                                            orderby m.Title
                                            select m.Title;
         

            var books = from m in _context.Books
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                books = books.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(BookTitle))
            {
                books = books.Where(x => x.Title == BookTitle);
            }

            // <snippet_search_selectList>
            Titles = new SelectList(await genreQuery.Distinct().ToListAsync());
            // </snippet_search_selectList>
            Books = await books.ToListAsync();

            /*var movies = from m in _context.Books
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            Books = await movies.ToListAsync();*/
        }
    }
}
