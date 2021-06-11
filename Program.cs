using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FactoryMethod_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            ShowWellCome();

            var opcao = GetOption();

            while(opcao != "3")
            {
                var chosenVehicle = GetVehicle();

                if (opcao == "1")
                {
                    BuyAtRetail(factory, chosenVehicle);
                }
                if (opcao == "2")
                {
                    BuyWholesale(factory, chosenVehicle);
                }

                opcao = GetOption();
            }

            Console.WriteLine("\nSaindo...");

            Thread.Sleep(2500);
        }

        private static void ShowWellCome()
        {
            Console.WriteLine("Seja Bem Vindo ao nosso programa de Exemplo do Factory Method...");
            Thread.Sleep(1500);
        }

        private static string GetOption()
        {
            Console.WriteLine("\nEscolha uma das opcões:");
            Console.WriteLine("\n1 - Comprar no Varejo\t2 - Comprar no Atacado\t3 - Sair");

            Console.Write("\nOpção Escolhida: ");
            var opcao = Console.ReadLine().Trim().ToUpper();

            while (opcao != "1" && opcao != "2" && opcao != "3")
            {
                Console.WriteLine("\nDigite uma Opção Válida!!!");

                opcao = GetOption();
            }

            return opcao;
        }

        private static string GetVehicle()
        {
            Console.WriteLine("\nEstes são os PRODUTOS de nossa FÁBRICA de Veículos: ");
            Console.WriteLine("\n-Carro\n-Bicicleta\n-Scooter");

            Console.Write("\nDigite o nome do veículo (como na legenda) que deseja comprar: ");
            return Console.ReadLine().Trim().ToLower();
        }

        private static void BuyAtRetail(VehicleFactory factory, string chosenVehicle)
        {
            try
            {
                Console.Clear();
                IProduct vehicle = factory.GetVehicle(chosenVehicle);
                vehicle.Buy();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void BuyWholesale(VehicleFactory factory, string chosenVehicle)
        {
            try
            {
                Console.Clear();
                Console.Write("\nDigite a quantidade de {0}s desejada: ", chosenVehicle);
                var qtdd = Convert.ToUInt16(Console.ReadLine());

                IProduct vehicle = factory.GetVehicle(chosenVehicle);
                vehicle.Buy(qtdd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
