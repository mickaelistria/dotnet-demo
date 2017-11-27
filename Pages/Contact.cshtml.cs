using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NewDotnetProject.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
        	int a = 4;
        	for (int i = 0; i < a; i++) {
        		Message += i;
        	} 
        	Message += "year";
            Message += System.DateTime.Now.DayOfWeek;
        }
    }
}
