using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Pattern
{
    /// <summary>
    /// Produto concreto => Bicicleta
    /// </summary>
    public class Bike : IProduct
    {
        /// <summary>
        /// Compra no Varejo
        /// </summary>
        public void Buy()
        {
            if (VerifyDecision())
            {
                Console.WriteLine("\nVocê comprou 1 Bicicleta pelo valor de: R$550,00" );
            }
            else
                Console.WriteLine("\nCompra Cancelada!");
        }

        /// <summary>
        /// Compra no Atacado
        /// </summary>
        /// <param name="quantify">Quantidade Desejada</param>
        public void Buy(uint quantify)
        {
           if (quantify < 1)
                throw new Exception("\nQuantidade mínima da Bicicleta é de 1 unidade.");
            else if (VerifyDecision())
            {
                Console.WriteLine("\nVocê comprou {0} Bicicleta pelo valor de: R${1},00", quantify, 550 * quantify);
            }
            else
                Console.WriteLine("\nCompra Cancelada!");
        }

        /// <summary>
        /// Verifica decisão de compra
        /// </summary>
        /// <returns>
        /// true => Compra Confirmada
        /// false => Compra Cancelada
        /// </returns>
        public bool VerifyDecision()
        {
            Console.Write("\nTem certeza de sua compra? (s/n) ");
            var answer = Console.ReadLine().ToUpper().Trim();

            while (answer != "S" && answer != "N")
            {
                Console.WriteLine("\nDigite apenas 's' ou 'n'!!!");

                Console.Write("\nTem certeza de sua compra? (s/n) ");
                answer = Console.ReadLine().ToUpper().Trim();
            }

            if (answer == "S")
                return true;
            else
                return false;
        }
    }
}
