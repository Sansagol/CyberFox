using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DryIoc;

namespace Sansagol.CyberFox.CyberFoxApi
{
    public class BaseBindings : IBinder
    {
        public Container MainContainer { get; private set; }

        public BaseBindings()
        {
            MainContainer.Register<IConfigurationManager, ConfigManager>();
        }
    }
}
