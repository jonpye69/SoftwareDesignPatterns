﻿using System;
using System.Diagnostics;

namespace DesignPatterns.StatePattern
{
    public class StatePatternDemo
    {
        public Context Context
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public StopState StopState
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public StartState StartState
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    
        public static void Output()
        {
            var context = new Context();

            var startState = new StartState();
            startState.DoAction(context);

            Trace.WriteLine(context.State + Environment.NewLine);

            var stopState = new StopState();
            stopState.DoAction(context);

            Trace.WriteLine(context.State + Environment.NewLine);
        }
    }
}
