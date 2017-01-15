using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CyberFox
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            BaseBindings.Init();
            base.OnStartup(e);
            Window mainWin = BaseBindings.WinFactory.GetMainWindow();
            if (mainWin != null)
                mainWin.Show();
        }
    }
}
