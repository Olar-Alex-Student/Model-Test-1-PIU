using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    public class Figura
    {
        public int[] Laturi;

        public Figura() 
        {
            Laturi = new int[] {};
        }

        public Figura(int NrLaturi)
        {
            Laturi = new int[NrLaturi];
        }

        public void TipFigura()
        {
            if( Laturi.Count() == 0 || Laturi.Count() == 1 || Laturi.Count() == 2)
            {
                Console.WriteLine("Inexistenta");
            }
            if (Laturi.Count() == 3)
            {
                Console.WriteLine("Triunghi");
            }
            if (Laturi.Count() == 4)
            {
                Console.WriteLine("Patrulater");
            }
            if (Laturi.Count() == 5)
            {
                Console.WriteLine("Pentagon");
            }
            if (Laturi.Count() == 6)
            {
                Console.WriteLine("Hexagon");
            }
            if (Laturi.Count() == 7)
            {
                Console.WriteLine("Heptagon");
            }
            if (Laturi.Count() == 8)
            {
                Console.WriteLine("Octagon");
            }
        }

        public int NrLaturi()
        {
            int Total = Laturi.Count();
            return Total;
        }

        public void LungimiLaturi()
        {
            for(int i = 0; i < Laturi.Count(); i++)
            {
                Console.WriteLine("Introdu val pt. latura {0}", i+1);
                string text = Console.ReadLine();
                int valoare = Int32.Parse(text);
                Laturi[i] = valoare;
            }
        }

        public void Latura1()
        {
            if (Laturi.Count() == 0)
            {
                Console.WriteLine("Latura 1 a figurii este: {0}",0);
            }
            else
            {
                Console.WriteLine("Latura 1 a figurii este: {0}", Laturi[0]);
            }
        }

        public int Perimetru()
        {
            int suma = Enumerable.Sum(Laturi);
            return suma;
        }
    }
}
