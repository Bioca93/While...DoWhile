using System;

namespace WhileDoWhileForForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

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


            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("i: " + i);
                i++;
            }

            //For
            Console.WriteLine();

            string[] paises = { "Portugal", "Espanha", "França", "Inglaterra" };
            int[] yyy = new int[10];

            yyy[0] = 100;
            yyy[1] = 101;
            yyy[2] = 102;
            yyy[3] = 103;
            yyy[4] = 104;

            Console.WriteLine(yyy[0]);
            Console.WriteLine(yyy[1]);
            Console.WriteLine(yyy[2]);
            Console.WriteLine(yyy[3]);
            Console.WriteLine(yyy[4]);

            Console.WriteLine();

            for (int j = 0; j < yyy.Length; j++)
            {
                if (j < 3)
                {
                    yyy[j] = 100 * j;
                }

                Console.WriteLine(yyy[j]);
            }

            Console.WriteLine();

            for (int j = 0; j < yyy.Length; j++)
            {
                yyy[j] = 100 * j;
                Console.WriteLine(yyy[j]);
            }

            // Foreach

            for (int j = 0; j < paises.Length; j++)
            {
                Console.WriteLine(paises[j]);

                if (j == 1)
                {
                    paises[j] = "Alemanha";
                }
            }


            foreach (string pais in paises)
            {

                if (pais == "Portugal")
                {
                    Console.WriteLine("Campeões da Europa");
                }
                else
                {
                    Console.WriteLine(pais);
                }
            }


            // Continue e Break

            int a = -1;
            while(a < 10)
            {
                a++;
                if (a == 3)
                {
                    continue;
                }

                if (a == 5)
                {
                    break;
                }

                Console.WriteLine(a);
            }

        }
    }
}
