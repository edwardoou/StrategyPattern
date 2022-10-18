using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Clase CostoAustralia que hereda el metodo Calculate
    // de la interface IProduccionCosto
    public class CostoAustralia : IProduccionCosto
    {
        public decimal Calculate(Product producto)
        {
            //Calculo del costo de produccion (ProductionCost)
            producto.ProductionCost = producto.Price * 0.2m;
            return producto.ProductionCost;
        }
    }
}
