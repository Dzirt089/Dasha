using Dasha.Data;
using Dasha.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dasha.Pages.Student
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<CreateModel> _logger;
        [BindProperty]
        public Students Students { get; set; }
        public IEnumerable<Students> ListStudents { get; set; }

        public CreateModel(ApplicationDbContext db, ILogger<CreateModel> logger)
        {
            _db = db;
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            ListStudents = _db.Students;
            var check = ListStudents.Where(item => item.Password.Contains(Students.Password)).FirstOrDefault();
            if (check is null)
            {
                await _db.Students.AddAsync(Students);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            //Здесь надо реализовать всплывающее сообщение об повторяющемся пароле и необходимости его изменить
            else
            {
                TempData["ErrorMessage"] = "Пароль уже используется. Пожалуйста, выберите другой пароль.";
                return Page();
            }
            
        }
    }
}
