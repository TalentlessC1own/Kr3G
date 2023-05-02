using Autofac;
using NLog;
using System.Drawing.Text;

namespace Kr3G
{
    internal static class Program
    {

       
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            
            using( var scope = PrepareContainer().BeginLifetimeScope())
            {
                var settingManager = scope.Resolve<ISettingManager>();
                settingManager.ApplySetting();
                var presenter = scope.Resolve<IPresenter>();
                
                
                
                presenter.Run();
                LogManager.logger.Error("qwe");

            };
        }
        private static IContainer PrepareContainer()
        {
            var builder = new ContainerBuilder();
            ContainerPreparer.Prepare(builder);
            return builder.Build();
        }
    }
}