using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucAnhCake.Shared
{
    public class Menu
    {
        public List<Cake> Cakes { get; set; }
            = new List<Cake>();
        public void Add(Cake cake)
            => Cakes.Add(cake);
        public Cake? GetCake(int id)
            => Cakes.SingleOrDefault(cake => cake.Id == id);
    }
}
