using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DucAnhCake.Shared;

namespace DucAnhCake.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly DucAnhCakeDbContext db;
        public OrdersController(DucAnhCakeDbContext db)
        {
            this.db = db;
        }
        [HttpPost("/orders")]
        public IActionResult InsertOrder([FromBody] ShoppingBasket basket)
        {
            Order order = new Order();
            order.Customer = basket.Customer;
            order.Cakes = new List<Cake>();
            foreach (int cakeId in basket.Orders)
            {
                var cake = db.Cakes.Single(p => p.Id == cakeId);
            }
            db.Orders.Add(order);
            db.SaveChanges();
            return Created("/orders", order.Id);
        }
    }
}
