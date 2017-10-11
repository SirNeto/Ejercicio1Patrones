using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Creacionales
{
    public class AverageCalculator : IMeanCalculator
    {
        public override double CalculateMean(List<double> data)
        {
            if (data.Count() > 0)
            {
                double ans = 0;
                foreach (double item in data)
                {
                    ans += item;
                }
                ans /= data.Count();
                return ans;
            } else
            {
                throw new Exception("There are not any elements in this list");
            }
        }
    }
}
