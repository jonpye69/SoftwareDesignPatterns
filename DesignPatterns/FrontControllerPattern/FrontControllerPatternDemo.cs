﻿namespace DesignPatterns.FrontControllerPattern
{
    public class FrontControllerPatternDemo
    {
        public FrontController FrontController
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output()
        {
            FrontController frontController = new FrontController();
            frontController.DispatchRequest("HOME");
            frontController.DispatchRequest("STUDENT");
        }
    }
}
