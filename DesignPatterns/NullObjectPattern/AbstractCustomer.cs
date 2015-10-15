﻿namespace DesignPatterns.NullObjectPattern
{
    public abstract class AbstractCustomer
    {
        protected string _name;

        public abstract bool IsNill();
        public abstract string GetName();
    }
}
