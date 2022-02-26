using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace GSPillows.Controllers
{
    public class SinghPillow : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
