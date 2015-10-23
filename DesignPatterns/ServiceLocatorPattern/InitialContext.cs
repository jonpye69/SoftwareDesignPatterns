﻿using System;

namespace DesignPatterns.ServiceLocatorPattern
{
    public class InitialContext
    {
        public Service2 Service2
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public Service1 Service1
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }
    
        public object Lookup(string jndiName)
        {
            if (jndiName.Equals("SERVICE1"))
            {
                Console.WriteLine("Looking up and creating a new Service1 object" + Environment.NewLine);
                return new Service1();
            }
            else if (jndiName.Equals("SERVICE2"))
            {
                Console.WriteLine("Looking up and creating a new Service2 object" + Environment.NewLine);
                return new Service2();
            }

            return null;
        }
    }
}
