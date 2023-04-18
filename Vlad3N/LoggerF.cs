using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Kr3G
{
    public static class LoggerF
    {
        public static Logger logger { get; } = LogManager.GetCurrentClassLogger();
        
    }
}
