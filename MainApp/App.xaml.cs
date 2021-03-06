﻿using Sansagol.CyberFox.UI;
using DryIoc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Sansagol.CyberFox
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IBinder binder = new BaseBindings();
            base.OnStartup(e);
            Window mainWin = binder.MainContainer.Resolve<IWindowsFactory>().GetMainWindow();
            if (mainWin != null)
                mainWin.Show();
        }
    }
}
