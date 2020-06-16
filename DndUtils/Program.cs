﻿using DndUtils.Race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DndUtils
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                List<int> t = StatRoller.RollStats();
                foreach (int j in t)
                    Console.WriteLine(j);
                Console.WriteLine(t.Sum() + "\n");
            }
            IRace abc = new HillDwarf();
            Console.WriteLine(abc.ToString());
        }
    }
}
