using System;

namespace WhileDoWhileForForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int x = 1;

            while (x <= 20)
            {
                Console.WriteLine("x é igual a: " + x);
                x++;
            }

            x = 1;
            int y = 20;

            while (x <= 20 && y >= 10)
            {
                Console.WriteLine("x é igual a: " + x + " e y é igual a:" + y);
                y--;
                x++;
            }

            char z = ' ';

            while (z != 'B')
            {
                Console.WriteLine(z);
                z = Convert.ToChar(Console.ReadLine());
            }
           
            int w = 9;

            do
            {
                w = Convert.ToInt32(Console.ReadLine());
            } while (w < 10);
*/
            int opcao;
            int counter = 0;

            do
            {
                Console.WriteLine("Menu de Hoje:");
                Console.WriteLine("1 - Bitoque");
                Console.WriteLine("2 - Açorda");
                Console.WriteLine("3 - Frango");
                Console.WriteLine("Numero de escolhas: " + counter);

                opcao = Convert.ToInt32(Console.ReadLine());
                counter++;

                Console.Clear();

                if (opcao > 3 || opcao < 1)
                {
                    Console.WriteLine("A opção " + opcao + " não é válida"); 
                    Console.WriteLine("Por favor insira uma opção válida");
                    Console.WriteLine();
                }
                     
            } while ((opcao > 3 || opcao < 1) && counter < 3);

        }
    }
}
