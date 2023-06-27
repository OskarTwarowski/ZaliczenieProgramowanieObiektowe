using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zad_2
{
    internal class Prostokat
    {
        //Niepubliczne pól double bokA i bokB
        private double bokA, bokB;


        public Prostokat(double a, double b)
        {
            bokA = a;
            bokB = b;
        }

        //Publicznych właściwości double BokA i BokB - obie mają w seterze sprawdzić, czy value jest skończoną nieujemną liczbą
        public double BokA
        {
            get => bokA;
            set
            {
                if (double.IsFinite(value) && value  > 0)
                {
                    bokA = value;
                }
                throw new ArgumentException("Długość boku musi być skończoną nieujemną liczbą");
            }
        }

        public double BokB
        {
            get => bokB;
            set
            {
                if (double.IsFinite(value) && value  > 0)
                {
                    bokB = value;
                }
                throw new ArgumentException("Długość boku musi być skończoną nieujemną liczbą");
            }
        }

        //statyczny słownik Dictionary<char, decimal> 

        public static Dictionary<char, decimal> wysokoscArkusza0 = new Dictionary<char, decimal>()
        {
            ['A'] = 1189,
            ['B'] = 1414,
            ['C'] = 1297
        };
        //Publicznej statycznej metody Prostokąt ArkuszPapieru, przyjmującej 1 argument typu string w formacie “Xi”
        public static Prostokat ArkuszPapieru(string format)
        {
            if (format.Length != 2)
            {
                throw new ArgumentException("Nieprawidłowy format arkusza, arkusz powinien być w postaci 'Xi'.");
            }

            char x = format[0];

            if (!wysokoscArkusza0.ContainsKey(x))
            {
                throw new ArgumentException("X powinno być literą wskazującą na stosowany szereg (A, B lub C)");
            }


            byte i;
            byte.TryParse(format[1].ToString(), out i);

            double pierwiastekZDwóch = Math.Sqrt(2);
            decimal wysokosc = wysokoscArkusza0[x];
            double bokA = Math.Round(Convert.ToDouble(wysokosc) / Math.Pow(pierwiastekZDwóch, i));
            double bokB = Math.Round(bokA / pierwiastekZDwóch);

            return new Prostokat(bokA, bokB);
        }
    }
}
