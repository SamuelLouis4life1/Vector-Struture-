using System;
using System.Globalization;

/// <summary>
/// a program that reads N real numbers and stores them in a vector next: 
/// Print all vector elements show on screen the sum and average of the vector elements
/// </summary>

namespace Vector3
{
    class Program
    {
        static void Main(string[] args)
        {

            int N;
            double[] A;

            N = int.Parse(Console.ReadLine());
            A = new double[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine("");

            double sum = 0.0;
            for (int i = 0; i < N; i++)
            {
                sum = sum + A[i];
            }
            double average = sum / N;

            Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(average.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();



        }
    }
}
