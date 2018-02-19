using Sansagol.CyberFox.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sansagol.CyberFox.UI.Model
{
    class MainModel: IModelbase
    {
        IWindowsFactory _WindowsFactory = null;

        public void Initialize(IWindowsFactory winFactory)
        {
            if (winFactory == null)
                throw new ArgumentNullException(nameof(winFactory));
            _WindowsFactory = winFactory;
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
