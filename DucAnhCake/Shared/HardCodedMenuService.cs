using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucAnhCake.Shared
{
    public class HardCodedMenuService : IMenuService
    {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu
            {
                Cakes = new List<Cake> {
                    new Cake(1, "Có đường", 20.99M, Sugar.Sugar),
                    new Cake(2, "Ít đường", 15.99M, Sugar.Lesssugar),
                    new Cake(3, "Không đường", 10.99M, Sugar.Nonesugar)
                }
            });
    }
}
