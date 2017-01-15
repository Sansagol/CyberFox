using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sansagol.CyberFox.SN
{
    /// <summary>
    /// This interface reralize classes which have a settings
    /// logic for current SN.
    /// </summary>
    interface ISettings
    {
        /// <summary>A user control for manually set any settings.</summary>
        DependencyObject Control { get; set; }
    }
}
