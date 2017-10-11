using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Creacionales
{
    public class TransFactory
    {
        public IStatisticsFactory GenerateDataTrans(int tr,int calculator)
        {
            IStatisticsFactory f;
            if (tr == 0)
                if (calculator == 1)
                    f = new SortAverageFactory();
                else
                    f = new SortStandardDeviationFactory();
            else if (tr == 1)
                if (calculator == 1)
                    f = new HistogramAverageFactory();
                else
                    f = new HistogramStandardDeviationFactory();
            else if (tr == 2)
                if (calculator == 1)
                    f = new SquareAverageFactory();
                else
                    f = new SquareStandardDeviationFactory();
            else
                if (calculator == 1)
                    f = new RootAverageFactory();
                else
                    f = new RootStandardDeviationFactory();
            return f;
        }
    }
}
