using NLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kr3G
{

     public interface ISettingManager
    {
        void ApplySetting();
    }
    public  class SettingManager : ISettingManager
    {
        private readonly IMainForm mainForm;

        public SettingManager(IMainForm mainForm)
        {
            this.mainForm = mainForm;
            mainForm.SettingsChanged += MainForm_UpdateAppSettings;
        }

        private void  MainForm_UpdateAppSettings(object? sender, EventArgs e)
        {
            UpdateAppSetting();
            
        }

        private void UpdateAppSetting()
        {
          
            UpdateAppSetting("BackColor", ColorTranslator.ToHtml(mainForm.BackGroundColor));
            UpdateAppSetting("TextColor", ColorTranslator.ToHtml(mainForm.TextColor));
            UpdateAppSetting("ShowGreetings", mainForm.ShowGreetings.ToString());
            UpdateAppSetting("LogPath", mainForm.LogPath);
           
        }
        public void ApplySetting()
        {
           
            mainForm.TextColor = ColorTranslator.FromHtml(ConfigurationManager.AppSettings["TextColor"]);
            mainForm.BackGroundColor = ColorTranslator.FromHtml(ConfigurationManager.AppSettings["BackColor"]);
            mainForm.ShowGreetings = Convert.ToBoolean(ConfigurationManager.AppSettings["ShowGreetings"]);
            mainForm.LogPath = ConfigurationManager.AppSettings["LogPath"];
            var q = ConfigurationManager.AppSettings["LogPath"];
            LogManager.ConfInit(ConfigurationManager.AppSettings["LogPath"]);



        }

        private  void UpdateAppSetting(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;


                settings[key].Value = value;

                configFile.Save(ConfigurationSaveMode.Full);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException ex)
            {
                LogManager.logger.Error(ex);
            }
        }
    }
}
