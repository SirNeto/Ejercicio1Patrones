﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Creacionales
{
    class HistogramStandardDeviationFactory : IStatisticsFactory
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
