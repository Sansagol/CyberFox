using CyberFox.Common;
using CyberFox.SN;
using CyberFox.UI;
using CyberFox.UI.Model;
using CyberFox.UI.View;
using CyberFox.UI.ViewModel;
using Sansagol.CyberFox.SN.VK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CyberFox
{
    /// <summary>
    /// It's a core class. Create bindings between all components.
    /// </summary>
    class BaseBindings
    {
        static List<ISettings> _SettingsControls = new List<ISettings>();
        public static List<ISettings> SettingsControls { get { return _SettingsControls; } }

        public static IWindowsFactory WinFactory { get; private set; }

        public static void Init()
        {
            InitControllers();
        }

        private static void InitControllers()
        {
            LoadSettingsControllers();
            WinFactory = new WindowsFactory(SettingsControls);
        }

        private static void LoadSettingsControllers()
        {
            VkSettings settings = new VkSettings();
            settings.Initialize(Constants.SettingsDirectory);

            _SettingsControls.Add(settings);
        }
    }
}
