using Sansagol.CyberFox.UI;
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
using System.IO;

namespace Sansagol.CyberFox
{
    /// <summary>
    /// It's a core class. Create bindings between all components.
    /// </summary>
    class BaseBindings : IBinder
    {
        /// <summary>Application custom settings directory.</summary>
        public string SettingsDirectory { get; private set; }

        Container _MainContainer = new Container();
        public Container MainContainer { get { return _MainContainer; } }

        private List<ISnWorker> _SnWorkers = new List<ISnWorker>();

        public BaseBindings()
        {
            InitConstants();

            _MainContainer.UseInstance(typeof(IBinder), this);

            _MainContainer.Register<IWindowsFactory, WindowsFactory>();
            _MainContainer.UseInstance(typeof(List<ISnWorker>), _SnWorkers);

            //Register snsWorkers
            _MainContainer.Register<ISnWorkerCreator, VkWorkerCreator>(Reuse.Singleton);
        }

        public void InitConstants()
        {
            SettingsDirectory = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData),
                "CyberFox");
        }
    }
}