using Sansagol.CyberFox.Common;
using Sansagol.CyberFox.SN.VK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansagol.CyberFox.SN.VK.ViewModels
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
