using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Creacionales
{
    public abstract class IStatisticsFactory
    {
        public abstract IDataTransformer GetDataTransformer();
        public abstract IMeanCalculator GetMeanCalculator();
    }
}
