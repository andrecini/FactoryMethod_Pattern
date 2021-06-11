using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Pattern
{
    /// <summary>
    /// Produto concreto => Carro
    /// </summary>
    public class Car : IProduct
    {
        /// <summary>
        /// Compra no Varejo
        /// </summary>
        public void Buy()
        {
            if (VerifyDecision())
            {
                Console.WriteLine("\nVocê comprou 1 Carro pelo valor de: R$15000,00");
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
                throw new Exception("\nQuantidade mínima do Carro é de 1 unidade.");
            else if (VerifyDecision())
            {
                Console.WriteLine("\nVocê comprou {0} Carro pelo valor de: R${1},00", quantify, 15000 * quantify);
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
