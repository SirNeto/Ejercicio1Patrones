using System;
using System.Collections.Generic;

namespace Practica1Creacionales
{
    public class DataContainer : Prototype
    {
        public List<Double> Data { get; set; }
        public override Prototype Clone()
        {
            DataContainer copy = new DataContainer();
            copy.Data = new List<Double>(this.Data);
            return copy;
        }
    }
}
