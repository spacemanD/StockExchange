using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    class ProductPanelCreator
    {
        /// <summary>
        /// Создания папнели продукта
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
       static  public ProductPanel CreatePanel(Product p)
        {
            ProductPanel panel = null;

            if (p is Stock)
            {
                panel = new BookPanel((Stock)p);
            }
            else if (p is Possessions)
            {
                panel = new PossessionPanel((Possessions)p);
            }
            else
            {
                panel = new BondsPanel((Bonds)p);
            }
            return panel;
        }
    }
}
