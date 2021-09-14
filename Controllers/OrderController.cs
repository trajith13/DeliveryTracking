using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList;
using DeliveryTracking.Models;

namespace DeliveryTracking.Controllers
{
    public class OrderController : Controller
    {

        private readonly SQLDataContext _db;

        public OrderController(SQLDataContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var orders = _db.Orders.OrderByDescending(x => x.OrderDateTime).Take(20).ToArray();
            return View();
        }
    }
}
