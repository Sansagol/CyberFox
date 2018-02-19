﻿using Sansagol.CyberFox.UI;
using Sansagol.CyberFox.UI.Model;
using Sansagol.CyberFox.UI.View;
using Sansagol.CyberFox.UI.ViewModel;
using DryIoc;
using Sansagol.CyberFox.Common;
using Sansagol.CyberFox.SN;
using Sansagol.CyberFox.SN.VK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sansagol.CyberFox
{
    /// <summary>
    /// It's a core class. Create bindings between all components.
    /// </summary>
    class BaseBindings : IBinder
    {
        Container _MainContainer = new Container();
        public Container MainContainer { get { return _MainContainer; } }

        List<ISnSettings> _SettingsControls = new List<ISnSettings>();
        public List<ISnSettings> SettingsControls { get { return _SettingsControls; } }

        private List<ISnWorker> _SnWorkers = new List<ISnWorker>();

        public BaseBindings()
        {
            _MainContainer.UseInstance(typeof(IBinder), this);
            _MainContainer.Register<IWindowsFactory, WindowsFactory>();
            _MainContainer.RegisterInstance(typeof(List<ISnSettings>), SettingsControls);
            _MainContainer.UseInstance(typeof(List<ISnWorker>), _SnWorkers);
        }

        public void Init()
        {
            LoadSettingsControllers();
        }

        private void LoadSettingsControllers()
        {
            ISnWorkerCreator vkCreator = new VkWorkerCreator();
            ISnWorker vkWorker = vkCreator.GetWorker();

            _SnWorkers.Add(vkWorker);
            _SettingsControls.Add(vkWorker.SnSettingsWorker);
        }
    }
}