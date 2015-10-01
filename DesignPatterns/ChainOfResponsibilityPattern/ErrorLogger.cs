﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    public class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level)
        {
            _level = level;
        }

        //Override
        protected override void Write(string message)
        {
            Console.WriteLine("Error Console::Logger: " + message + Environment.NewLine);
        }
    }
}