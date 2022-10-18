using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ProduccionCosto
    {
        // Funcion Calcular que necesita como parametros a
        // una clase de tipo Product y una clase que hereda 
        public decimal Calcular(Product producto, IProduccionCosto produccionCosto)
        {
            //Retorna el costo de produccion ya calculado. (ProductionCost)
            return produccionCosto.Calculate(producto);
        }
    }
}
