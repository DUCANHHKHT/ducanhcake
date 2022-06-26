using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace DucAnhCake.Shared
{
    public class Cake
    {
        public Cake(int id, string name, decimal price,
        Sugar sugar)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Sugar = sugar;
        }
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public Sugar Sugar { get; }
        [JsonIgnore]
        public ICollection<Order>? Orders { get; set; }
    }
}
