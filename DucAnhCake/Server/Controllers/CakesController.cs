using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DucAnhCake.Shared;

namespace DucAnhCake.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CakesController : ControllerBase
    {
        private readonly DucAnhCakeDbContext db;
        public CakesController(DucAnhCakeDbContext db)
        {
            this.db = db;
        }

        [HttpGet("/cakes")]
        public IQueryable<Cake> GetCakes()
        => this.db.Cakes;

        [HttpPost("/cakes")]
        public IActionResult InsertCake([FromBody] Cake cake)
        {
            db.Cakes.Add(cake);
            db.SaveChanges();
            return Created($"cakes/{cake.Id}", cake);
        }
    }
}
