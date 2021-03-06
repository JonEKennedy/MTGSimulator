﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Game testGame = new Game(
                new List<Player>()
                {
                    new Player("Jon", TestingFactory.GrizzlyDeck()),
                    new Player("Isaac", TestingFactory.GrizzlyDeck())
                }
                );
            testGame.Start();

            Console.ReadKey();
        }
    }
}
