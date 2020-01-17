using Microsoft.AspNetCore.Mvc;

namespace RoutingTest.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Index()
        {
            return View();
        }

        // GET: Orders/Details/5
        public ActionResult Details(int id)
        {
            return View(id);
        }
    }
}