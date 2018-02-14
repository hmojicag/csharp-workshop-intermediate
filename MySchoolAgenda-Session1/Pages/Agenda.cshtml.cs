using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MySchoolAgenda.Pages
{
    public class AgendaModel : PageModel
    {
        public ICollection<IRenderizable> Notes { get; set; }

        public void OnGet()
        {
            Notes = new List<IRenderizable>();

            HomeworkNote homework = new HomeworkNote();
            homework.Description = "Hacer la tarea";
            homework.Subject = "Matematicas";
            homework.CreatedDate = DateTime.Now;
            homework.FinalDate = new DateTime(2018, 02, 15);

            EventNote eventNote = new EventNote() {
                Description = "Fiesta en casa de Nestor",
                CreatedDate = DateTime.Now,
                FinalDate = new DateTime(2018, 02, 16, 19, 30, 30),
                Place = "Casa de Nestor"
            };

            ImportantHomeworkNote importantHomework = new ImportantHomeworkNote();
            importantHomework.Description = "Estudia para Calculo";
            importantHomework.Subject = "Calculo";
            importantHomework.CreatedDate = DateTime.Now;
            importantHomework.FinalDate = new DateTime(2018, 02, 18);

            StickyNote stickyNote = new StickyNote() {
                Description = "Bew awesome",
                CreatedDate = DateTime.Now,
                Color = Color.Red
            };

            Notes.Add(homework);
            Notes.Add(eventNote);
            Notes.Add(importantHomework);
            Notes.Add(stickyNote);

        }
    }
}
