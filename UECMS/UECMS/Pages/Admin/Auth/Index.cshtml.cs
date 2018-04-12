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
        [StringLength(20, MinimumLength = 3, ErrorMessage = "用户名输入不正确")]
        [Required(ErrorMessage = "请输入用户名")]
        public string LoginName { get; set; }
        [StringLength(18, MinimumLength = 6, ErrorMessage = "输入密码长度不正确")]
        [Required(ErrorMessage = "请输入密码")]
        [DataType(DataType.Password)]
        public string LoginPass { get; set; }
    }
}