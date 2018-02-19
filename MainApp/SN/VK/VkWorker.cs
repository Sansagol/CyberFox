using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansagol.CyberFox.SN.VK
{
    class VkWorker : ISnWorker
    {
        public ISnSettings SnSettingsWorker { get; private set; }

        public ISnAuthorization SnAuthorizationWorker { get; private set; }

        public VkWorker(ISnSettings settsWorker, ISnAuthorization authWorker)
        {
            SnSettingsWorker = settsWorker ?? throw new ArgumentNullException(nameof(settsWorker));
            SnAuthorizationWorker = authWorker ?? throw new ArgumentNullException(nameof(authWorker));
        }
    }
}
