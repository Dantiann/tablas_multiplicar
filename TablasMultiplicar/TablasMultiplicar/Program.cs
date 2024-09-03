using System;

namespace TablasMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un número del 1 al 10");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
                for (int j = 1; j <= numero; j++)
                {
                    int resultado1 = i * j;
                    Console.WriteLine(i + "*" + j + " = " + resultado1);
                }

            Console.WriteLine("*************");

            for (int i = 1; i <= 10; i++)
            {
                int resultado2 = numero * i;
                Console.WriteLine(numero + "x" + i + " = " + resultado2);
            }

            Console.ReadKey();
        }
    }
}