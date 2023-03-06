using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kr3G
{
    public class GraphData
    {
        public GraphData(double[] xs, double[] ys)
        {
            this.xs = xs;
            this.ys = ys;
        }

        public double[] xs { get; private set; }
        public double[] ys { get; private set; }
    }
}
