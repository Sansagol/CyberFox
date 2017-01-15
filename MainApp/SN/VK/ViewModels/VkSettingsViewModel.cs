using CyberFox.Common;
using CyberFox.SN.VK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberFox.SN.VK.ViewModels
{
    class VkSettingsViewModel : ViewModelBase
    {
        /// <summary>ID of application.</summary>
        public string AppID { get; set; }

        public VkSettingsModel Model { get; set; }

        public VkSettingsViewModel(VkSettingsModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));
            Model = model;

        }
    }
}
