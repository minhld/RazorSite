using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MySite.Controllers
{
    public class LoginController : Controller
    {
        public string Index()
        {
            return "";
        }
        
        // GET: /<controller>/
        public string SubmitInfo(string username, string password)
        {
            return "you entered " + username;
        }
    }
}
