using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    //Este es el interface que almacenara el metodo Calculate
    public interface IProduccionCosto
    {
        decimal Calculate(Product product);
    }
}
