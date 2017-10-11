using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Creacionales
{
    public class DataFactory
    {
        public IDataGenertor GenerateDataGenerator(int x)
        {
            IDataGenertor Data;
            if (x == 0)
                Data = new RandomDataGenerator();
            else if (x == 1)
                Data = new PolynomicDataGenerator();
            else
                Data = new StepDataGenerator();
            return Data;
        }

    }
}
