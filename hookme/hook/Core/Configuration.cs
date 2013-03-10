using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace hook.Core
{
    class Configuration
    {
        public string urlSponsor = "http://www.itsm3.com/hookme/sponsor/sponsor.html";


        private string _key = @"SOFTWARE\hooker";

        public string deviareLicenseBase64 = string.Empty;
        public List<string> lstPluginsSearchPath = new List<string>();

        public void SaveConfiguration()
        {
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(_key);

            rk.SetValue("deviareLicensePath", deviareLicenseBase64);

            string fullPluginSearchPath = string.Empty;
            foreach (string path in lstPluginsSearchPath)
            {
                if (!string.IsNullOrEmpty(path))
                    fullPluginSearchPath += path + ";";
            }
            rk.SetValue("lstPluginsSearchPath", fullPluginSearchPath);

        }

        public void LoadConfiguration()
        {
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(_key);

            if (string.IsNullOrEmpty(deviareLicenseBase64))
                deviareLicenseBase64 = (string)rk.GetValue("deviareLicensePath", string.Empty);

            string fullPluginSearchPath = (string)rk.GetValue("lstPluginsSearchPath", @"C:\Python26\Lib;C:\Python27\Lib;");

            for (int i = 0 ; i < fullPluginSearchPath.Split(new char[] { ';' }).Length; i++)
            {
                string path = fullPluginSearchPath.Split(new char[] { ';' })[i];

                if (!string.IsNullOrEmpty(path))
                    lstPluginsSearchPath.Add(path);
            }
        }

    }
}
