using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Creacionales
{
    public class RootTransformer : IDataTransformer
    {
        public override List<double> TransformData(List<double> data)
        {
            List<double> ans = new List<double>();
            foreach (double item in data){
                ans.Add(Math.Sqrt(item));
            }
            return ans;
        }
    }
}
