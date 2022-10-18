using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CostoChina : IProduccionCosto
    {
        public decimal Calculate(Product producto)
        {
            producto.ProductionCost = producto.Price * 0.1m;
            return producto.ProductionCost;
        }
    }
}
