using System;


/// a program to read an N value and then the name of N people.Then show the names read.


/// <summary> o mesmo exemplo usando foreach
/// foreach (string elemento in vet)
/// {
///     Console.WriteLine(elemento);
/// }
/// </summary>

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            string[] vect = new string[N];

            for (int i = 0; i < N; i++)
            {
                vect[i] = Console.ReadLine();
            }

            Console.WriteLine("Names read: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(vect[i]);
            }
            Console.ReadLine();
        }
    }
}