﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //polymorphism to create object of type IQuittable
            IQuittable ImOut = new Employee();
            ImOut.Quit();
            Console.ReadLine();
        }
    }
}
