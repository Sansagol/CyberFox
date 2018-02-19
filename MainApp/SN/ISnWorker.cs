using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansagol.CyberFox.SN
{
    interface ISnWorker
    {
        ISnSettings SnSettingsWorker { get; }
        ISnAuthorization SnAuthorizationWorker { get; }
    }
}
