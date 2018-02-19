using Sansagol.CyberFox.SN;
using Sansagol.CyberFox.UI.Model;
using Sansagol.CyberFox.UI.View;
using Sansagol.CyberFox.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sansagol.CyberFox.UI
{
    class WindowsFactory : IWindowsFactory
    {
        static List<ISnSettings> _SettingsControls = null;
        IBinder _Binder = null;

        public WindowsFactory(List<ISnSettings> settingsControls, IBinder binder)
        {
            _SettingsControls = settingsControls ?? throw new ArgumentNullException(nameof(settingsControls));
            _Binder = binder ?? throw new ArgumentNullException(nameof(binder));
        }

        public Window GetMainWindow()
        {
            MainModel mainWindowModel = new MainModel();
            mainWindowModel.Initialize(this, _Binder);
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
