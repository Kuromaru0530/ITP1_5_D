﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ITP1_5_D
{
    class Program
    {
        static void Main()
        {
            int Input = int.Parse(Console.ReadLine());

            for(int i = 3; i <= Input; i++)
            {
                if (i % 3 == 0 || i.ToString().Contains('3')) Console.Write(" " + i);
            }
            Console.WriteLine();
        }
    }
}