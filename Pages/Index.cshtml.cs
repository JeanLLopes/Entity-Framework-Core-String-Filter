using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity_Framework_Core_String_Filter_Tips.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_Core_String_Filter_Tips.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var contacts = await _context.Contacts.ToListAsync();
            ViewData.Add("Contacts", contacts);
            
            var contactsLike = await _context.Contacts.Where(c => EF.Functions.Like(c.LastName, "Sw%")).ToListAsync();
            ViewData.Add("ContactsLike", contactsLike);

            var contactsCompare = await _context.Contacts.Where(c => String.Compare(c.FirstName, "D", StringComparison.Ordinal) < 0).ToListAsync();
            ViewData.Add("contactsCompare", contactsCompare);

            return Page(); 
        }
    }
}
