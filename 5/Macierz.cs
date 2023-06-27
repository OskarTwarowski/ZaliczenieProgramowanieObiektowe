using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5
{
    class Macierz<T> : IEquatable<Macierz<T>> where T : IEquatable<T>
    {
        private T[,] tablica;

        public Macierz(int wymiarWierszy, int wymiarKolumn)
        {
            tablica = new T[wymiarWierszy, wymiarKolumn];
        }

        public T this[int wiersz, int kolumna]
        {
            get { return tablica[wiersz, kolumna]; }
            set { tablica[wiersz, kolumna] = value; }
        }

        public static bool operator ==(Macierz<T> m1, Macierz<T> m2)
        {
            if (m1 is null || m2 is null)
                return ReferenceEquals(m1, m2);

            if (m1.tablica.GetLength(0) != m2.tablica.GetLength(0) ||
                m1.tablica.GetLength(1) != m2.tablica.GetLength(1))
                return false;

            for (int i = 0; i < m1.tablica.GetLength(0); i++)
            {
                for (int j = 0; j < m1.tablica.GetLength(1); j++)
                {
                    if (!m1.tablica[i, j].Equals(m2.tablica[i, j]))
                        return false;
                }
            }

            return true;
        }

        public static bool operator !=(Macierz<T> m1, Macierz<T> m2)
        {
            return !(m1 == m2);
        }

        public bool Equals(Macierz<T> other)
        {
            return this == other;
        }
    }
}
