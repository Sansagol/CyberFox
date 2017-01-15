using CyberFox.Common;
using CyberFox.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CyberFox.UI.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        MainModel _Model = null;
        public ICommand ShowSettingsWindowCmd { get; set; }

        public MainViewModel(MainModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));
            _Model = model;

            ShowSettingsWindowCmd = new RelationCommand(ShowSettingsWindowCmdHandler);
        }

        private void ShowSettingsWindowCmdHandler(object obj)
        {
            _Model.ShowSettingsWindow(true);
        }
    }
}
