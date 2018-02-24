using Sansagol.CyberFox.Common;
using Sansagol.CyberFox.SN;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sansagol.CyberFox.UI.ViewModel
{
    public class SettingsViewModel : ViewModelBase
    {
        public ObservableCollection<DependencyObject> SettingsControls { get; } = new ObservableCollection<DependencyObject>();

        public SettingsViewModel(IList<ISnSettings> settingsControls)
        {
            if (settingsControls == null)
                throw new ArgumentNullException(nameof(settingsControls));

            settingsControls.Where(s => s.Control != null)
                .ToList()
                .ForEach(s => SettingsControls.Add(s.Control));
        }
    }
}
