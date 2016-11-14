﻿using DesignPatterns.Interfaces;

namespace DesignPatterns.AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract IColor GetColor(string color);
        public abstract IShape GetShape(string shape);
    }
}
