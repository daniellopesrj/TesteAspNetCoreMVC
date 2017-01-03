using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore;
using System.Text.Encodings.Web;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteAspNetCore2.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action...";

        }

        // GET: /HelloWorld/Welcome
        public string Welcome()
        {
            return "This is a Welcome action method...";
        }

    }
}
