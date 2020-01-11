using System;
using System.Globalization;

/// <summary>
/// It is an example of object type vectors to make a program to read an integer N and the data (name and price) of N products.
/// Store the N products in a vector. then show the average price of the products
/// </summary>

namespace Vector6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Product[] vect = new Product[N];
            for (int i = 0; i < N; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < N; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / N;
            Console.WriteLine("AVERAGE PRICE: " + avg.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
