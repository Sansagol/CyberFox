using CyberFox.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CyberFox.Common
{
    interface IModelbase
    {
        void Initialize(IWindowsFactory winFactory);
    }
}
