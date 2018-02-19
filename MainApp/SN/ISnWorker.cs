using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansagol.CyberFox.SN
{
    interface ISnWorker
    {
        /// <summary>Id of the social network</summary>
        int SnId { get; }

        /// <summary>Title of the social network.</summary>
        string SnTitle { get; }

        ISnSettings SnSettingsWorker { get; }
        ISnAuthorization SnAuthorizationWorker { get; }
    }
}
