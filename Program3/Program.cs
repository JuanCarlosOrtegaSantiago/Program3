using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10];
            Random r = new Random();


            for (int i = 0; i < 10; i++)
            {

                arreglo[i] = r.Next(10, 101);
                Console.WriteLine(arreglo[i]);

            }


            int mayor = 0;

            foreach (var item in arreglo)
            
                if (item > mayor)
                    mayor = item;

            Console.WriteLine("El mayor es de: {0}",mayor);

            Console.ReadLine();
        }
    }
}
