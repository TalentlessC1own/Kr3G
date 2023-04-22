using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using System.Configuration;

namespace Kr3G
{
    public static class LoggerF
    {
        public static Logger logger { get; } = LogManager.GetCurrentClassLogger();

        public static void  ConfInit()
        {
            var configuration = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = ConfigurationManager.AppSettings["LogPath"] + "/logs/${shortdate}.log" };
            logfile.Layout = "${longdate} {uppercase:${level}} ${message}";

            configuration.AddRule(NLog.LogLevel.Trace, NLog.LogLevel.Fatal, logfile);

            NLog.LogManager.Configuration = configuration;
        }
        
    }
}
