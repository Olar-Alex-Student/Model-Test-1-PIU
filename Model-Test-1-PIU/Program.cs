using FiguraGeometrica;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Test_1_PIU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figura figura1 = new Figura();
            Figura figura2 = new Figura(5);
            figura1.TipFigura();
            figura2.TipFigura();
            Console.WriteLine("Intordu Laturile pentru Figura 1:");
            figura1.LungimiLaturi();
            Console.WriteLine("Intordu Laturile pentru Figura 2:");
            figura2.LungimiLaturi();
            Console.WriteLine("Figura 1 nr de laturi: {0}", figura1.NrLaturi());
            Console.WriteLine("Figura 2 nr de laturi: {0}", figura2.NrLaturi());
            figura1.Latura1();
            figura2.Latura1();
            Console.WriteLine("Figura 1 are perimetrul: {0}", figura1.Perimetru());
            Console.WriteLine("Figura 2 are perimetrul: {0}", figura2.Perimetru());
            Console.ReadKey();
        }
    }
}
