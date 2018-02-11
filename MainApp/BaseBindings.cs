using CyberFox.Common;
using CyberFox.SN;
using CyberFox.UI;
using CyberFox.UI.Model;
using CyberFox.UI.View;
using CyberFox.UI.ViewModel;
using DryIoc;
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
    class BaseBindings : IBinder
    {
        Container _MainContainer = new Container();
        public Container MainContainer { get { return _MainContainer; } }

        static List<ISettings> _SettingsControls = new List<ISettings>();
        public static List<ISettings> SettingsControls { get { return _SettingsControls; } }

        public BaseBindings()
        {
            _MainContainer.Register<IWindowsFactory, WindowsFactory>();
            _MainContainer.RegisterInstance(typeof(List<ISettings>), SettingsControls);
        }

        public static void Init()
        {
            LoadSettingsControllers();
        }

        private static void LoadSettingsControllers()
        {
            VkSettings settings = new VkSettings();
            settings.Initialize(Constants.SettingsDirectory);

            _SettingsControls.Add(settings);
        }
    }
}
