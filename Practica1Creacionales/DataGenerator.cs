using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Creacionales
{
    public interface IDataGenertor
    {
        List<Double> GenerateData();
    }
    class RandomDataGenerator : IDataGenertor
    {
        public List<double> GenerateData()
        {
            Random rand = new Random();
            List<double> res = new List<double>();
            for (int i = 0; i < 50; i++)
                res.Add(rand.NextDouble()*100);
            return res;
        }
    }

    class PolynomicDataGenerator : IDataGenertor
    {
        public List<double> GenerateData()
        {
            List<double> res = new List<double>();
            for (int i = 0; i < 50; i++)
                res.Add(i*i*i - i*i);
            return res;

        }
    }


    class StepDataGenerator : IDataGenertor
    {
        public List<double> GenerateData()
        {
            List<double> res = new List<double>();
            for (int i = 0; i < 25; i++)
                res.Add(1);
            for (int i = 25; i < 50; i++)
                res.Add(1);
            return res;

        }
    }
}
