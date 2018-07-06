namespace Fluffy_Duffy_Munchkin_Cats.Controllers
{
    using Data;
    using Microsoft.AspNetCore.Mvc;
    using Models;

    public class CatsController : Controller
    {
        public CatsController(FdmcContext context)
        {
            this.Context = context;
        }

        public FdmcContext Context { get; set; }

        public IActionResult Details(int id)
        {
            var cat = this.Context.Cats.Find(id);
            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Cat model)
        {
            this.Context.Cats.Add(model);
            this.Context.SaveChanges();
            return Redirect("/Cats/Details/"+model.Id);
        }
    }
}