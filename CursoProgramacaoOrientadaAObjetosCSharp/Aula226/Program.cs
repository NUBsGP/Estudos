﻿using System;

namespace Aula226
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2018, 12, 16, 8, 10, 45);
            Console.WriteLine(dateTime.ElapsedTime());
        }
    }
}