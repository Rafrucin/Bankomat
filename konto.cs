using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class konto
    {
        public enum trans { obciazenie, uznanie}

        public double saldo { get; set; } = 0;

        public static List<Tuple<trans, double>> transakcje { get; set; } = new List<Tuple<trans, double>>();

        public static void uznania (double kwota)
        {
            transakcje.Add(Tuple.Create( trans.uznanie, kwota));
        }

        public static void obciazenia(double kwota)
        {
            transakcje.Add(Tuple.Create(trans.obciazenie, -kwota));
        }

    }
}
