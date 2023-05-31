using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor
{
    internal class Program
    {
        public static void Exercicio1()
        {
            float media = 0;
            int[] vet2;
            Console.WriteLine("diga um tamanho");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);


            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição [{0}] = {1}", i, vet2[i]);
                media = vet2[i] + media;

            }
            media = media / (float)t;
            Console.WriteLine("a media aridimentica é" + media);

            Console.ReadKey();
        }
        public static void Exercicio2()
        {

            int[] vet2;
            Console.WriteLine("diga o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);


            }
            int somaP = 0;
            int somaI = 0;
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição [{0}] = {1}", i, vet2[i]);
                if (vet2[i] % 2 == 0)
                {
                    somaP += vet2[i];
                }
                else
                {
                    somaI += vet2[i];
                }

            }
            Console.WriteLine("a soma dos pares é" + somaP);
            Console.WriteLine("a soma dos impares é" + somaI);
            Console.ReadKey();
        }
        public static void Exercicio3()
        {

            int[] vet2;
            Console.WriteLine("entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);


            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição [{0}] = {1}", i, vet2[i]);


            }
            Console.WriteLine();
            for (int i = t - 1; i >= 0; i--)
            {

                Console.WriteLine("posição [{0}] = {1}", i, vet2[i]);


            }


            Console.ReadKey();
        }
        public static void Exercicio4()
        {
            float media = 0;
            int[] vet2;
            Console.WriteLine("diga um tamanho");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);


            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição [{0}] = {1}", i, vet2[i]);
                if (vet2[i] % 3 == 0 && vet2[i] % 5 == 0)
                {
                    media = vet2[i] + media;
                }


            }

            media = media / (float)t;
            Console.WriteLine("a media é" + media);

            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            int opcao;
            Console.WriteLine("-_-_-_-_-_-_menu-_-_-_-_-_-_");
            Console.WriteLine("para sair digite 0");
            Console.WriteLine("para fazer o ex 1 - digite 1");
            Console.WriteLine("para fazer o ex 2 - digite 2");
            Console.WriteLine("para fazer o ex 3 - digite 3");
            Console.WriteLine("para fazer o ex 4 - digite 4");
            Console.WriteLine("======================================");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                default:
                    Console.WriteLine("nao consego ler este numero");
                    break;

            }
        }
    }
}








