﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var grisly = TestingFactory.CreateGrislyBear();

            Console.ReadKey();
        }
    }
}
