using CyberFox.Common;
using CyberFox.SN;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CyberFox.UI.ViewModel
{
    public class SettingsViewModel : ViewModelBase
    {
        ObservableCollection<DependencyObject> _SettingsControls =
            new ObservableCollection<DependencyObject>();
        public ObservableCollection<DependencyObject> SettingsControls
        {
            get { return _SettingsControls; }
        }

        public SettingsViewModel(List<ISettings> settingsControls)
        {
            if (settingsControls == null)
                throw new ArgumentNullException(nameof(settingsControls));
            settingsControls.Where(s => s.Control != null)
                .ToList()
                .ForEach(s => _SettingsControls.Add(s.Control));
        }
    }
}
