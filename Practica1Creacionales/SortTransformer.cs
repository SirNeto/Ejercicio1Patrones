using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Creacionales
{
    public class SortTransformer : IDataTransformer
    {
        public override List<double> TransformData(List<double> data)
        {
            List<double> ans = new List<double>(data);
            ans.Sort();
            return ans;
        }
    }
}
