using System;

namespace Ejemplo_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese primer dato: ");
            int dato1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese segundo dato: ");
            int dato2 = Convert.ToInt32(Console.ReadLine());
            
            if (dato1 < dato2)
                for (int i = dato1; i <= dato2; i++)
                {
                    Console.WriteLine(i);
                }
            if (dato1 > dato2)
                for (int i = dato1; i >= dato2; i--)
                {
                    Console.WriteLine(i);
                }
            else
                Console.WriteLine("son iguales");

            Console.ReadKey();
        }
    }
}
