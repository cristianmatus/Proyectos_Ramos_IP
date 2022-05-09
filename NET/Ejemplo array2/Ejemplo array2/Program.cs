using System;

namespace Ejemplo_array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Ejemplo_array2 = new int[5];

            Console.WriteLine("Ingrese valor");
            Ejemplo_array2[0] = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < Ejemplo_array2.Length; i++)
            {
                Console.WriteLine(Ejemplo_array2);
            }
            Console.ReadKey();
        }
    }
}
