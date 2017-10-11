using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Creacionales
{
    public class StandardDeviationCalculator : IMeanCalculator
    {
        public override double CalculateMean(List<double> data)
        {
            if (data.Count() > 0)
            {
                double average = 0;
                double ans = 0;
                int n = data.Count();
                foreach (double item in data)
                {
                    average += item;
                }
                average /= n;
                foreach (double item in data)
                {
                    ans += (item - average) * (item - average);
                }
                ans = Math.Sqrt(ans / (n - 1));
                return ans;
            }
            else
            {
                throw new Exception("There are not any elements in this list");
            }
        }
    }
}
