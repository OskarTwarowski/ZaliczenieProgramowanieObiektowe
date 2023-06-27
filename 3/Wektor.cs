using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3
{
    public class Wektor
    {
        //Pola double[] współrzędne
        private double[] współrzedne; 




        //Konstruktor Wektor(byte wymiar)
        public Wektor(byte wymiar)    
        {
            współrzedne = new double[wymiar];
        }


        //Wektor(params double[] współrzędne
        public Wektor(params double[] współrzędne)
        {
            this.współrzedne = współrzędne;
        }

        public double this[byte indeks]
        {
            get { return współrzedne[indeks]; }
            set { współrzedne[indeks] = value; }
        }


        //Własność tylko do odczytu double Długość {get;}
        public double Długość
        {
            get { return Math.Sqrt(Obliczenia.IloczynSkalarny(this, this)); }
        }


        //Własność tylko do odczytu byte Wymiar { get; }
        public byte Wymiar
        {
            get { return (byte)współrzedne.Length; }
        }
       
        public static Wektor Suma(params Wektor[] wektory)
        {
            return Obliczenia.Suma(wektory);
        }
        //operator +(Wektor,Wektor)
        public static Wektor operator +(Wektor v1, Wektor v2)
        {
            return Obliczenia.Dodaj(v1, v2);
        }
        //operator -(Wektor,Wektor)
        public static Wektor operator -(Wektor v1, Wektor v2)
        {
            return Obliczenia.Odejmowanie(v1, v2);
        }
        //operatory* (Wektor, double)
        public static Wektor operator *(Wektor v, double skalar)
        {
            return Obliczenia.Mnożenie(v, skalar);
        }
        //operatory* (double), Wektor)
        public static Wektor operator *(double skalar, Wektor v)
        {
            return Obliczenia.Mnożenie(skalar, v);
        }
        //operatory (Wektor,double), zwracające nową instancję, będącą wektorem podzielonym przez skalar

        public static Wektor operator /(Wektor v, double skalar)
        {
            return Obliczenia.Dzielenie(v, skalar);
        }



        public override string ToString()
        {
            string separator = " | ";
            string result = string.Join(separator, współrzedne);
            return $"({result})";
        }

    }
}
