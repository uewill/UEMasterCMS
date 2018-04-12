using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace UECMS.Pages.Admin.Auth
{
    public class IndexModel : PageModel
    {
        public InputModel Input { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("../Main/Index");
            }
            return Page();
        }
    }

    public class InputModel
    {
        [StringLength(20, MinimumLength = 3, ErrorMessage = "�û������벻��ȷ")]
        [Required(ErrorMessage = "�������û���")]
        public string LoginName { get; set; }
        [StringLength(18, MinimumLength = 6, ErrorMessage = "�������볤�Ȳ���ȷ")]
        [Required(ErrorMessage = "����������")]
        [DataType(DataType.Password)]
        public string LoginPass { get; set; }
    }
}