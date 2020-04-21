using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bankomat
{
    public class metody
    {
        public static void wplac(konto dolce)
        {
            Console.WriteLine("Podaj kwote do wplaty");
            //add validation
            string read = Console.ReadLine();
            if (CzyDouble(read))
            {
                
                double kwota = Convert.ToDouble(read);
                if (kwota >= 0)
                {
                    dolce.saldo += kwota;
                    konto.uznania(kwota);
                }
                else
                {
                    Console.WriteLine("kwota musi byc wieksza od zera");
                    wplac(dolce);
                }  
            }
            else
            {
                Console.WriteLine("Podaj poprawna kwote");
                wplac(dolce);
            }
            
            
        }
        public static void wyplac(konto dolce)
        {
            Console.WriteLine("Podaj kwote do wyplaty");
            //add validation
            string read = Console.ReadLine();
            if (CzyDouble(read))
            {

                double kwota = Convert.ToDouble(read);
                if (kwota >= 0 && dolce.saldo >= kwota)
                {
                    dolce.saldo -= kwota;
                    konto.obciazenia(kwota);
                }
                else if (kwota > dolce.saldo)
                {
                    Console.WriteLine("Wyplata nie moze przekraczac salda");
                    wyplac(dolce);
                }
                else
                {
                    Console.WriteLine("kwota musi byc wieksza od zera");
                    wyplac(dolce);
                }
            }
            else
            {
                Console.WriteLine("Podaj poprawna kwote");
                wplac(dolce);
            }


        }


        private static bool CzyDouble (string input)
        {
            bool output = true;

            try
            {
                double kwota = Convert.ToDouble(input);
            }
            catch (Exception)
            {

                output = false;
            }


            return output;
        }

        public static void ListaTransakcji (konto dolce)
        {
            if (konto.transakcje.Count == 0)
            {
                Console.WriteLine("Lista transakcji jest pusta");
            }
            else
            {
                foreach (var trans in konto.transakcje)
                {
                    Console.WriteLine(trans);
                }
            }
            Console.WriteLine("Nacisnij dowolny klawisz");
            Console.ReadKey();
        }

    }
}
