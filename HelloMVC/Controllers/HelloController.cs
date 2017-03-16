using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method ='post'>" +
                "<input type='text' name = 'name' />" +
                "<select name='language'>" +
                "<option value='English'>English</option>" +
                "<option value='Spanish'>Spanish</option>" +
                "<option value='French'>French</option>" +
                "<option value='German'>German</option>" +
                "<option value='Italian'>Italian</option>" +
                "<input type ='submit' value='Greet me!' />" +
                "</form>";

            //return Content(html, "text/html");
            return Content(html, "text/html");
        }

        // /Hello end up at this controller
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name="World", string language = "English")
        {
            string message = "";
            if (language == "English")
            {
                message = "<h1>Hello {0}!</h1>";
            }
            if (language == "Spanish")
            {
                message = string.Format("<h1>Hola {0}!</h1>", name);
            }
            if (language == "French")
            {
                message = string.Format("<h1>Bonjour {0}!</h1>", name);
            }
            if (language == "German")
            {
                message = string.Format("<h1>Hallo {0}!</h1>", name);
            }
            if (language == "Italian")
            {
                message = string.Format("<h1>Ciao {0}!</h1>", name);
            }
            return Content(message, "text/html");
        }

        // Handle requests to /Hello/NAME (URL segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}!</h1>", name), "text/html");
        }


        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }

}
