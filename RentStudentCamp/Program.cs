﻿using System;

namespace RentHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] vect = new Student[10];

            Console.Write("How many rooms will be rented ? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine();
                Console.WriteLine($" rent #{i}: ");
                Console.Write("Name: ");
                string _name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Rooms: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Student(_name, email);

            }
            Console.WriteLine();
            Console.WriteLine("Occupied rooms: ");
            for (int i = 0; i < 10; i++)
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }

            Console.ReadLine();
        }
    }
}