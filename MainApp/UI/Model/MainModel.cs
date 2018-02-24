using Sansagol.CyberFox.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DryIoc;

namespace Sansagol.CyberFox.UI.Model
{
    class MainModel: IModelbase
    {
        IWindowsFactory _WindowsFactory = null;
        IBinder _Binder = null;

        public void Initialize(IBinder binder)
        {
            _Binder = binder ?? throw new ArgumentNullException(nameof(binder));
            _WindowsFactory = _Binder.MainContainer.Resolve<IWindowsFactory>();
        }

        public void ShowSettingsWindow(bool isModal)
        {
            Window winToShow = _WindowsFactory.GetSettingsWindow();
            if (winToShow != null)
            {
                if (isModal)
                    winToShow.ShowDialog();
                else
                    winToShow.Show();
            }
        }
    }
}
