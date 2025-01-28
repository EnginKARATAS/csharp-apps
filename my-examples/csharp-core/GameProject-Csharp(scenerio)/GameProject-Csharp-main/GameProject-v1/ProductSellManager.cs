using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_v1
{
    //Bu menegerde yapılan satışlar, kampanya yapabilir
    class ProductSellManager : Kampanya, IProductPresentationServiece
    {
        public void SellProduct(Gamer gamer)
        {
            Console.WriteLine("Satis yap -->" + gamer.Name);
        }
    }
}
