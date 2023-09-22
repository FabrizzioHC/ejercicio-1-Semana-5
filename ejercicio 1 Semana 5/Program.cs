using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1_Semana_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el primer numero:");
            int num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero:");
            int num_2 = int.Parse(Console.ReadLine());
            int producto = 0;

            for (int i = 0; i < num_2; i++)
            {
                producto += num_1;
            }

            Console.WriteLine($"el producto es: {producto}");
            Console.ReadKey();
        }
    }
}
