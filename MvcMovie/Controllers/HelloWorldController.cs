using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /MyController/
        public string Index()
        {
            return "This is lazy action . . . meh . . .";
        }

        //
        // GET: /MyController/Sparta/
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"What up {name}, NumNums is: {numTimes}");
        }
    }
}
