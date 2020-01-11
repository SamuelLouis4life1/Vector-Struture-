using System;
using System.Globalization;

/// <summary>
/// a program to read N numbers. after name (just a word). 
/// age and height of N people later, show on screen average people height and show also percentage of people under 16 year olds
/// </summary>

namespace Vector4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] names = new string[N];
            int[] ages = new int[N];
            double[] height = new double[N];

            // data reading
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                names[i] = s[0];
                ages[i] = int.Parse(s[1]);
                height[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            // average height calculation
            double sum = 0.0;
            for (int i = 0; i < N; i++)
            {
                sum = sum + height[i];
            }
            double averageHeights = sum / N;
            Console.WriteLine("Average height: " + averageHeights.ToString("F2", CultureInfo.InstalledUICulture));

            // percentage of people under 16 years old
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (ages[i] < 16)
                {
                    count++;
                }
            }
            double percentage = (double)count / N * 100.0;
            Console.WriteLine("People under 16: "
                + percentage.ToString("F1", CultureInfo.InstalledUICulture) + "%");

            Console.ReadLine();
        }
    }
}
