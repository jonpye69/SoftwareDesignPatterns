﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public abstract class Observer
    {
        protected Subject _subject;
        public abstract void Update();
    }
}
