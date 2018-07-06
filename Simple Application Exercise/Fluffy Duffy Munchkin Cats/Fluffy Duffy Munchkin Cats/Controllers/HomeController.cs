namespace Fluffy_Duffy_Munchkin_Cats.Controllers
{
    using Data;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    public class HomeController : Controller
    {
        public HomeController(FdmcContext context)
        {
            this.Context = context;
        }

        public FdmcContext Context { get; private set; }

        public IActionResult Index()
        {
            var cats = this.Context.Cats.ToList();
            return View(cats);
        }
    }
}