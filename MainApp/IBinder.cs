using DryIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansagol.CyberFox
{
    /// <summary>
    /// Interface represents a class which bind all rependencies.
    /// </summary>
    interface IBinder
    {
        /// <summary>
        /// The property gets the main DI container.
        /// </summary>
        Container MainContainer { get; }

        string SettingsDirectory { get; }
    }
}
