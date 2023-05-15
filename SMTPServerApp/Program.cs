using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.pc2.dayana
{
    class Program
    {
        static void Main(string[] args)
        {

            int lanzamiento_1 = 0;
            int lanzamiento_2 = 0;
            int lanzamiento_3 = 0;
            int valor_1 = 0;
            int valor_2 = 0;
            int valor_3 = 0;

            Console.WriteLine("ingrese el valor de los tres lanzamientos");
            lanzamiento_1 = int.Parse(Console.ReadLine());
            lanzamiento_2 = int.Parse(Console.ReadLine());
            lanzamiento_3 = int.Parse(Console.ReadLine());

            valor_1 = lanzamiento_1 + lanzamiento_2;
            valor_2 = lanzamiento_2 + lanzamiento_3;
            valor_3 = lanzamiento_1 + lanzamiento_3;

            if ((valor_1) == lanzamiento_3)
            {
                Console.WriteLine("GANA");
            }
            else if ((valor_2) == lanzamiento_1)
            {
                Console.WriteLine("GANA");
            }
            else if ((valor_3) == lanzamiento_2)
            {
                Console.WriteLine("GANA");
            }
            else
            {
                Console.WriteLine("PIERDE");
            }
            Console.ReadLine();
        }
    }
}
