using System;
using System.Globalization;

/// <summary>
/// a program to read a positive integer N, then any N numbers and store them in a vector. 
/// Then show all vector elements on screen
/// </summary>

namespace VectorsStruture
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i;
            double[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            for (i = 0; i < N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();

        }
    }
}
