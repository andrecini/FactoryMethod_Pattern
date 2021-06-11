using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Pattern
{
    /// <summary>
    /// VehicleFactory Concreta, utilizada para crição se produtos
    /// para venda.
    /// 
    /// OBS.: Se for necessário criar uma VehicleFactory que utiliza
    /// o método GetVehicle de forma diferente (Selecionando o pro-
    /// duto a partir de uma enumeração, por exemplo), basta criar 
    /// outra classe ConcreteVehicleFactory (com nome diferente, é
    /// claro), herdar a classe abstrata VehicleFactory e sobrescre-
    /// ver o método de outra maneira!
    /// </summary>
    public class ConcreteVehicleFactory : VehicleFactory
    {
        /// <summary>
        /// A assinatura do método ainda usa uma abstração do Produto,
        /// mantendo o Criador independente das classes dos produtos
        /// Concretos.
        /// </summary>
        /// <param name="vehicle">Veículo Escolhido</param>
        /// <returns>Objeto que implementa a interface IProduct</returns>
        public override IProduct GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "scooter":
                    return new Scooter();
                case "bicicleta":
                    return new Bike();
                case "carro":
                    return new Car();
                default:
                    throw new Exception($"\nO Veículo '{Vehicle}' não existe em nossos Registros");
            }
        }
    }
}
