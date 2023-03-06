using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kr3G
{
    public interface ICalculator
    {
        GraphData GetGraphData(DataHolder<double> dataHolder);

    }

    public class Calculator : ICalculator
    {
        public GraphData GetGraphData(DataHolder<double> dataHolder)
        {
            List<double> xs = new List<double>();
            List<double> ys = new List<double>();

  

            for (double  y = dataHolder.LeftBorder; y <= dataHolder.RightBorder; y+=dataHolder.Step)
            {
                ys.Add(y);

                xs.Add(dataHolder.R * Math.Acos((dataHolder.R - y)/dataHolder.R) - Math.Sqrt(2* dataHolder.R * y - Math.Pow(y,2)));
            }
            return new GraphData(xs.ToArray(), ys.ToArray());
        }

       
    }
}
