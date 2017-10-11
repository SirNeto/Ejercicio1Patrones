using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Creacionales
{
    class SquareAverageFactory : IStatisticsFactory
    {
        public override IDataTransformer GetDataTransformer()
        {
            return new SquareTransformer();
        }

        public override IMeanCalculator GetMeanCalculator()
        {
            return new StandardDeviationCalculator();
        }
    }
}
