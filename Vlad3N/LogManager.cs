using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using System.Configuration;

namespace Kr3G
{
    public static class LogManager
    {
        public static Logger logger { get; } = NLog.LogManager.GetCurrentClassLogger();

        public static void  ConfInit(string path )
        {
            var configuration = new NLog.Config.LoggingConfiguration();
            var q = ConfigurationManager.AppSettings["LogPath"];
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = path + "/" + "logs/${shortdate}.log" };
            logfile.Layout = "${longdate} {uppercase:${level}} ${message}";

            configuration.AddRule(NLog.LogLevel.Trace, NLog.LogLevel.Fatal, logfile);

            NLog.LogManager.Configuration = configuration;
        }
        
    }
}
