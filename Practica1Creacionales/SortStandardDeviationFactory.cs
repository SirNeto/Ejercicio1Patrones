﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Creacionales
{
    public class SortStandardDeviationFactory : IStatisticsFactory
    {
        public override IDataTransformer GetDataTransformer()
        {
            return new SortTransformer();
        }

        public override IMeanCalculator GetMeanCalculator()
        {
            return new StandardDeviationCalculator();
        }
    }
}
