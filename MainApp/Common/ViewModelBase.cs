using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansagol.CyberFox.Common
{
    /// <summary>Base class for all view models.</summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            if (!string.IsNullOrWhiteSpace(propertyName))
            {
                var e = new PropertyChangedEventArgs(propertyName);
                PropertyChanged?.Invoke(this, e);
            }
        }
    }
}
