using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {

            konto dolce = new konto();
            bool koniec = false;
            while (!koniec)
            {
                Console.Clear();
                Console.WriteLine($"Saldo konta wynosi { dolce.saldo }");
                Console.WriteLine("Wybierz operacje");
                Console.WriteLine("a. Wplac");
                Console.WriteLine("b. Wyplac");
                Console.WriteLine("c. Lista transakcji");
                Console.WriteLine("d. Koniec");
                char wybor = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                switch (wybor)
                {
                    case 'a':
                        metody.wplac(dolce);
                        break;
                    case 'b':
                        metody.wyplac(dolce);
                        break;
                    case 'c':
                        metody.ListaTransakcji(dolce);
                        break;
                    case 'd':
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }


            }



        }
    }
}
