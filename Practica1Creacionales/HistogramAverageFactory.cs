using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Creacionales
{
    public class HistogramAverageFactory : IStatisticsFactory
    {
        public override IDataTransformer GetDataTransformer()
        {
            return new HistogramTransformer();
        }

        public override IMeanCalculator GetMeanCalculator()
        {
            return new AverageCalculator();
        }
    }
}
