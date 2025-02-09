using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager dm = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var dataValues = dm.TGetList();
            return View(dataValues);
        }
        [HttpGet]
        public IActionResult DestinationDetails(int id = 1)
        {
            ViewBag.i = id;
            var values = dm.TGetByID(id);
            if (values == null)
            {
                return NotFound("id yok");
            }
            return View(values);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
        }
    }
}
