using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Pattern
{
    /// <summary>
    /// A Interface Produto determina os métodos que 
    /// todos os produtos devem implementar.
    /// </summary>
    public interface IProduct
    {
        //Método para compras no Varejo
        void Buy();

        //Método para compras no Atacado
        void Buy(uint quantify);

        //Método para verificar decisão de compra
        bool VerifyDecision();
    }
}
