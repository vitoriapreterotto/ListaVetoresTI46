using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetoresTI46
{
    internal class Lista01
    {
        internal void exercicio01()
        {
            double[] numeros = new double[10];
            double soma = 0;

            Console.WriteLine("Digite 10 números: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
                soma += numeros[i];
            }

            double media = soma / 10;

            Console.WriteLine($"A média aritmética é: {media}");
        }

        internal void execicio02()
        {
            string[] nome = new string[5];

            Console.WriteLine("Digite 5 nomes: ");

            for (int i = 0;i < 5;i++)
            {
                Console.WriteLine($"Nome {i + 1}: ");
                nome[i] = Console.ReadLine();
            }

            Array.Sort(nome);

            Console.WriteLine("\nNomes em ordem alfabética:");
            foreach (string nomes in nome)
            {
                Console.WriteLine(nomes);
            }
        }

        internal void exercicio03()
        {
            int[] numeros = new int[10];
            bool repetidos = false;

            Console.WriteLine("Digite 10 números: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        repetidos = true;
                        break;
                    }
                }
                if (repetidos) break;
            }

            if (repetidos)
            {
                Console.WriteLine("Há números repetidos!");
            }
            else
            {
                Console.WriteLine("NÃO há números repetidos!");
            }
        }

        internal void exercicio04()
        {
            char[] caracteres = new char[5];

            Console.WriteLine("Digite 5 caracteres:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Caractere {i + 1}: ");
                caracteres[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            Console.WriteLine("Digite uma palavra de 5 letras para verificar se é um anagrama:");
            string palavra = Console.ReadLine();

            if (palavra.Length != 5)
            {
                Console.WriteLine("A palavra deve ter exatamente 5 letras.");
                return;
            }

            bool isAnagrama = VerificaAnagrama(caracteres, palavra.ToCharArray());

            if (isAnagrama)
            {
                Console.WriteLine("A palavra é um anagrama dos caracteres digitados.");
            }
            else
            {
                Console.WriteLine("A palavra não é um anagrama dos caracteres digitados.");
            }
        }
        
        static bool VerificaAnagrama(char[] caracteres, char[] palavra)
        {
            Array.Sort(caracteres);
            Array.Sort(palavra);
            return new string(caracteres) == new string(palavra);
        }

        internal void exercicio05()
        {
            int[] numeros = new int[10];

            Console.WriteLine("Digite 10 números: ");

            for (int i = 0;i < 10;i++)
            {
                Console.WriteLine($"Número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Reverse(numeros);

            Console.WriteLine("Números na ordem invertida: ");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }

        internal void exercicio06()
        {
            int[] numeros = new int[5];

            Console.WriteLine("Digite 5 números inteiros:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            List<int> pares = new List<int>();

            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    pares.Add(numero);
                }
            }

            Console.WriteLine("\nNúmeros pares:");

            if (pares.Count > 0)
            {
                foreach (int par in pares)
                {
                    Console.WriteLine(par);
                }
            }
            else
            {
                Console.WriteLine("Não há números pares no vetor.");
            }
        }
    }



}
