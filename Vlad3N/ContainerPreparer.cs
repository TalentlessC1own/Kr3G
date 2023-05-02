using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kr3G
{
    public static class ContainerPreparer
    {
        public static void Prepare(ContainerBuilder builder)
        {
            RegisterPresenterParts(builder);
            RegisterPresenter(builder);
            RegisterSettingManager(builder);

        }

        private static void RegisterSettingManager(ContainerBuilder builder)
        {
            builder.RegisterType<SettingManager>().As<ISettingManager>();
        }
        private static void RegisterPresenter(ContainerBuilder builder)
        {
            builder.RegisterType<Presenter>().As<IPresenter>();
        }
        private static void RegisterPresenterParts(ContainerBuilder builder)
        {
            builder.RegisterType<MainForm>().As<IMainForm>().SingleInstance();
            builder.RegisterType<MessageService>().As<IMessageService>();
            builder.RegisterType<Calculator>().As<ICalculator>();
            builder.RegisterType<Validator>().As<IValidator>();
            builder.RegisterType<FileManager>().As<IFileManager>();
            builder.RegisterType<ExcelExport>().As<IDataExport>();
           
        }
    }
}
