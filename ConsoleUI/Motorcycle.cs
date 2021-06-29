﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
   public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }

        public override void DriveAbstract()
        {
            Console.WriteLine("This Motorcycle is in drive!");
        }

        public bool HasSideCart { get; set; } = true;

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
    }
}
