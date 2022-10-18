using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CostoUSA : IProduccionCosto
    {
        public decimal Calculate(Product producto)
        {
            producto.ProductionCost = producto.Price * 0.22m;
            return producto.ProductionCost;
        }
    }
}
