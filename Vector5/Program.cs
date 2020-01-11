using System;
using System.Globalization;

/// <summary>
/// a program that that reads N integer numbers then shows to the screen the average of the number
/// </summary>

namespace Vertor5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] vect = new double[N];

            for (int i = 0; i < N; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 0.0;
            for (int i = 0; i < N; i++)
            {
                sum += vect[i];
            }

            double avg = sum / N;
            Console.WriteLine("AVERAGE HEIGHT: " + avg.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
