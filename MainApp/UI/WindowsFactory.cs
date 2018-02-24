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
using DryIoc;

namespace Sansagol.CyberFox.UI
{
    class WindowsFactory : IWindowsFactory
    {
        IBinder _Binder = null;

        public WindowsFactory(IBinder binder)
        {
            _Binder = binder ?? throw new ArgumentNullException(nameof(binder));
        }

        public Window GetMainWindow()
        {
            MainModel mainWindowModel = new MainModel();
            mainWindowModel.Initialize(_Binder);
            MainViewModel mainVM = new MainViewModel(mainWindowModel);
            return new MainWindow(mainVM);
        }

        public Window GetSettingsWindow()
        {
            var snCreators = _Binder.MainContainer.Resolve<IEnumerable<ISnWorkerCreator>>();
            List<ISnSettings> workers = new List<ISnSettings>();
            foreach (ISnWorkerCreator cr in snCreators)
            {
                workers.Add(cr.GetWorker().SnSettingsWorker);
            }
            SettingsViewModel settingsVM = new SettingsViewModel(workers);
            SettingsWindow settingsWindow = new SettingsWindow(settingsVM);
            return settingsWindow;
        }
    }
}
