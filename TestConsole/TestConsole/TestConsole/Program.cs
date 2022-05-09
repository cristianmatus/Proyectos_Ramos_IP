using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese valor");
            Console.WriteLine("-------------");

            int caseSwitch = 0;

            switch(caseSwitch)
            {
                case 1:
                    Console.WriteLine("Este es el primer caso");
                    break;
                case 2:
                    Console.WriteLine("Este es el segundo caso");
                    break;
                default:
                    Console.WriteLine("Este es el tercer caso");
                    break;
            }
        }
    }
}
