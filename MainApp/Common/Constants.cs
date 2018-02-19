using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansagol.CyberFox.Common
{
    class Constants
    {
        /// <summary>Application custom settings directory.</summary>
        public static string SettingsDirectory { get; private set; }

        static Constants()
        {
            SettingsDirectory = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData),
                "CyberFox");
        }
    }
}
