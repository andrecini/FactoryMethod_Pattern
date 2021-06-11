using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Pattern
{
    /// <summary>
    /// A classe abstrata VehicleFactory declara o método de fabricação
    /// que deve retornar um objeto que implementa a interface Iproduct.
    /// 
    /// As sub-classes geralmente fornecem a implementação deste método. 
    /// </summary>
    public abstract class VehicleFactory
    {
        /// <summary>
        /// Retorna um objeto Produto
        /// </summary>
        /// <param name="vehicle">Veículo Escolhido</param>
        /// <returns>Objeto que implementa a interface IProduct</returns>
        public abstract IProduct GetVehicle(string vehicle);
    }
}
