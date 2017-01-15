using CyberFox.SN;
using CyberFox.UI.Model;
using CyberFox.UI.View;
using CyberFox.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CyberFox.UI
{
    class WindowsFactory : IWindowsFactory
    {
        static List<ISettings> _SettingsControls = null;

        public WindowsFactory(List<ISettings> settingsControls)
        {
            if (settingsControls == null)
                throw new ArgumentNullException(nameof(settingsControls));
            _SettingsControls = settingsControls;
        }

        public Window GetMainWindow()
        {
            MainModel mainWindowModel = new MainModel();
            mainWindowModel.Initialize(this);
            MainViewModel mainVM = new MainViewModel(mainWindowModel);
            return new MainWindow(mainVM);
        }

        public Window GetSettingsWindow()
        {
            SettingsViewModel settingsVM = new SettingsViewModel(_SettingsControls);
            SettingsWindow settingsWindow = new SettingsWindow(settingsVM);
            return settingsWindow;
        }
    }
}
