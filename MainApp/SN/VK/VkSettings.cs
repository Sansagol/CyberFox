using Sansagol.CyberFox.SN.VK.Models;
using Sansagol.CyberFox.SN.VK.ViewModels;
using Sansagol.CyberFox.SN.VK.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sansagol.CyberFox.SN.VK
{
    class VkSettings : ISnSettings
    {
        private string _SettingsFile = string.Empty;
        public DependencyObject Control { get; set; }

        /// <summary>Initialize settings for VK.</summary>
        /// <param name="settingsPath">Setting directory path.</param>
        /// <exception cref="InvalidOperationException"/>
        public void Initialize(string settingsPath)
        {
            if (!Directory.Exists(settingsPath))
                try
                {
                    Directory.CreateDirectory(settingsPath);
                    _SettingsFile = Path.Combine(settingsPath, "vkSettings.sts");
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException(
                        "Unable to create full path to the settings file",
                        ex);
                }
            ConfigBindings();
        }

        private void ConfigBindings()
        {
            VkSettingsModel model = new VkSettingsModel();
            VkSettingsViewModel vm = new VkSettingsViewModel(model);
            VkSettingsControl control = new VkSettingsControl(vm);

            Control = control;
        }
    }
}
