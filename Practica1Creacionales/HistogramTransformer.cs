using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Creacionales
{
    public class HistogramTransformer : IDataTransformer
    {
        public override List<double> TransformData(List<double> data)
        {
            double max = 0, min = 1000;
            int ranges = 10;
            List<double> ans = new List<double>();
            foreach (double item in data)
            {
                if (item > max)
                {
                    max = item;
                }
                if (item < min)
                {
                    min = item;
                }
            }


            for (int i = 0; i < ranges; i++)
            {
                double s = (max - min)/10 * ((double)i) + min;
                double e = (max - min)/10 * ((double)i + 1) + min;
                int count = 0;
                foreach (double item in data)
                {
                    if (item >= s && item < e)
                    {
                        count++;
                    }
                }
                ans.Add(count);
            }

            return ans;
        }
    }
}
