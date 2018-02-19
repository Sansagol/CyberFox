using Sansagol.CyberFox.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansagol.CyberFox.SN.VK
{
    class VkWorkerCreator : ISnWorkerCreator
    {
        public ISnWorker GetWorker()
        {
            ISnSettings settings = new VkSettings();
            settings.Initialize(Constants.SettingsDirectory);
            ISnAuthorization snAuthorization = new VkAuthorize();
            ISnWorker vkWorker = new VkWorker(settings, snAuthorization);

            return vkWorker;
        }
    }
}
