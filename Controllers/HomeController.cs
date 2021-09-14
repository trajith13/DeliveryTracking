using DeliveryTracking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PagedList;
namespace DeliveryTracking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly SQLDataContext _db;

        public HomeController(SQLDataContext db, ILogger<HomeController> logger)
        {
            _db = db;
            _logger = logger;
        }
       

        public IActionResult Index()
        {
            //Order order = new Order();
            //order.OrderCode = "ORD003";
            //order.comments="test data";
            //_db.Orders.Add(order);
            //_db.SaveChanges();
            int PageIndex = 1;
            int Pagesize = 5;
            IPagedList<Order> ord = null;
            List<Order> orders = _db.Orders.ToList();
            ord=orders.ToPagedList(PageIndex, Pagesize);
            return View(ord);
        }

        public IActionResult Edit(long ID)
        {
            long editID = ID;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
