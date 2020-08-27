using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DTO;
using Microsoft.AspNetCore.Mvc;
using WebClient.Filters;
using WebClient.Models;

namespace WebClient.Controllers
{
    
    public class OrderController : BaseController
    {
        AppService app = new AppService();
        public IActionResult Index()
        {
            long id = long.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            List<Orders> list = app.Order.GetOrders(id);
            return View(list);
        }
        public IActionResult Pay(Orders obj)
        {
            long id = long.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            obj.AccountId = id;
            obj.Id = CartId;
            obj.Status = "P";

            if (app.Order.Pay(obj) > 0)
            {
                OrderItems orderItems = new OrderItems();
                Orders orders = new Orders();
                return RedirectToAction("Index");
            }
            return Redirect("/");
        }
    }
}
