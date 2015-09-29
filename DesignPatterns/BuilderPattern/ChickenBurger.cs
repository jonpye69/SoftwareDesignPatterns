﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class ChickenBurger : Burger
    {
        //Override
        public override string name()
        {
            return "Chicken Burger";
        }

        //Override
        public override float price()
        {
            return 50.0F;
        }
    }
}
