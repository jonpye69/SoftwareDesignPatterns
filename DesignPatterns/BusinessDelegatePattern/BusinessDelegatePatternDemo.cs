﻿namespace DesignPatterns.BusinessDelegatePattern
{
    public class BusinessDelegatePatternDemo
    {
        public BusinessDelegate BusinessDelegate
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public ClientBusiness Client
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
            BusinessDelegate businessDelegate = new BusinessDelegate();
            businessDelegate.SetServiceType("EJB");

            ClientBusiness client = new ClientBusiness(businessDelegate);
            client.DoTask();

            businessDelegate.SetServiceType("JMS");
            client.DoTask();
        }
    }
}
