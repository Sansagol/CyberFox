﻿using Sansagol.CyberFox.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sansagol.CyberFox.SN.VK.Views
{
    /// <summary>
    /// Interaction logic for SettingsControl.xaml
    /// </summary>
    public partial class VkSettingsControl : UserControl
    {
        ViewModelBase _VM = null;
        public VkSettingsControl(ViewModelBase viewModel)
        {
            InitializeComponent();
            DataContext = _VM = viewModel;
        }
    }
}
