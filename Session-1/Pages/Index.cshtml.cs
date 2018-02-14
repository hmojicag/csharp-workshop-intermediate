using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csharp_workshop_intermediate.Notes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace csharp_workshop_intermediate.Pages
{
    public class IndexModel : PageModel
    {
        public List<IRenderizable> Notes { get; set; }
        
        public void OnGet()
        {
            Notes = new List<IRenderizable>();
            Notes.Add(new HomeworkNote());
            Notes.Add(new ImportantHomeworkNote());
            Notes.Add(new EventNote());
            Notes.Add(new StickyNote());
        }
    }
}
