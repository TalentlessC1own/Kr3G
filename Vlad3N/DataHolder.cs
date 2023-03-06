using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kr3G
{
    public class DataHolder<T>
    {
        public DataHolder(T leftBorder, T rightBorder, T step, T r)
        {
            LeftBorder = leftBorder;
            RightBorder = rightBorder;
            Step = step;    
            R = r;
        }
        public T LeftBorder { get; private set; }
        public T RightBorder { get; private set; }
        public T Step { get; private set; }
        public T R { get; private set; }

        public string GetStringData()
        {
            return $"{LeftBorder} {RightBorder} {Step} {R}";
        }

 
    }
}
