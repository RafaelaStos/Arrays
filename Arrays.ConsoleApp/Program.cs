using System.Drawing;

namespace Arrays.ConsoleApp
{
    internal class Program
    {
        static int valor = 0;
        static void Main(string[] args)
        {
            int[] sequencia = [-5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6];


            MaiorValor(sequencia);
            MenorValor(sequencia);
            ValorMedio(sequencia);
            NumerosNegativos(sequencia);
            MostrarSequencia(sequencia);
            remocao(sequencia);
            EncontrarMaioresValores(sequencia);
        }

        private static void MostrarSequencia(int[] sequencia)
        {
            for (int i = 0; i < sequencia.Length; i++)
            {
                Console.Write(sequencia[i] + " ");
            }
        }

        static void MaiorValor(int[] sequencia)
        {
            for (int i = 0; i < sequencia.Length; i++)
            {

                if (sequencia[i] > valor)

                    valor = sequencia[i];
            }
            Console.WriteLine($"O maior número da sequencia é: {valor}");
        }

        static void MenorValor(int[] sequencia)
        {

            for (int i = 0; i < sequencia.Length; i++)
            {

                if (sequencia[i] < valor)
                    valor = sequencia[i];
            }
            Console.WriteLine($"O menor número da sequencia é: {valor}");
        }

        static void ValorMedio(int[] sequencia)
        {
            int media, soma = 0;
            for (int i = 0; i < sequencia.Length; i++)
            {

                soma += sequencia[i];
            }
            media = soma / sequencia.Length;
            Console.WriteLine($"O valor médio é: {media}");
        }

        static void NumerosNegativos(int[] sequencia)
        {
            for (int i = 0; i < sequencia.Length; i++)
            {

                if (sequencia[i] < 0)

                    Console.WriteLine($"{sequencia[i]}");



            }
        }

        static void remocao(int[] sequencia)
        {
            Console.WriteLine("\nDigite o numero para remover da sequencia:");
            int remover = Convert.ToInt32(Console.ReadLine());

            int[] novaSequencia = new int[sequencia.Length - 1];
            int cont = 0;
            for (int i = 0; i < sequencia.Length; i++)
            {
                if (sequencia[i] != remover)
                {


                    novaSequencia[cont] = sequencia[i];
                    cont++;
                }
            }
            for (int i = 0; i < novaSequencia.Length; i++)
            {
               
       
             Console.Write($"{novaSequencia[i]} ");
            }
            Console.WriteLine();
        }

        private static void EncontrarMaioresValores(int[] sequencia)
        {
            int[] copia = new int[sequencia.Length];

            Array.Copy(sequencia, copia, sequencia.Length);

            Array.Sort(copia);

            Array.Reverse(copia);

            Console.WriteLine($"\nOs 3 maior valores são: [{copia[0]}, {copia[1]}, {copia[2]}]");
        }

    }
}
