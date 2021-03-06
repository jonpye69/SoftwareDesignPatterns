﻿using System;

namespace DesignPatterns.CompositeEntityPattern
{
    public class CompositeEntity
    {
        private CoarseGainedObject cgo = new CoarseGainedObject();

        public CoarseGainedObject CoarseGainedObject
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public void SetData(string data1, string data2)
        {
            cgo.SetData(data1, data2);
        }

        public string[] GetData()
        {
            return cgo.getData();
        }
    }
}
