using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Creacionales
{
    public class SquareTransformer : IDataTransformer
    {
        public override List<double> TransformData(List<double> data)
        {
            List<double> ans = new List<double>();
            foreach (double item in data)
            {
                ans.Add(item * item);
            }
            return ans;
        }
    }
}
