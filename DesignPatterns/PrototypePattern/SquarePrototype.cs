﻿using System;

namespace DesignPatterns.PrototypePattern
{
    public class SquarePrototype : ShapePrototype
    {
        public SquarePrototype()
        {
            type = "Square";
        }

        //Override
        public override void Draw()
        {
            Console.WriteLine("Inside Square::Draw() method." + Environment.NewLine);
        }
    }
}
