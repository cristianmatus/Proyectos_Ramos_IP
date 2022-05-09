using System;

namespace Ejemplo_array1
{
    class Program
    {              
        static void Main(string[] args)
        {


            string[] Ejemplo_array1 = new string[6];
            Ejemplo_array1[0] = "Hola";
            Ejemplo_array1[1] = "Bonita";
            Ejemplo_array1[2] = "Espero";
            Ejemplo_array1[3] = "Que";
            Ejemplo_array1[4] = "Te";
            Ejemplo_array1[5] = "Mejores";
            int i = 0;
            
            //for (int i = 0; i < Ejemplo_array1.Length; i++)
            //{
             //   Console.WriteLine(" " + Ejemplo_array1[i]);
            //}

            foreach (var item in Ejemplo_array1)
            {
                Console.WriteLine(" " + Ejemplo_array1[i]);
                i++;
            }
            Console.ReadKey();
        }
    }
}
