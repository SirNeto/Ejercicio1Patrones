using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Creacionales
{
    public abstract class IDataTransformer
    {
        public abstract List<Double> TransformData(List<Double> data);
    }
}
