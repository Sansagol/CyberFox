using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sansagol.CyberFox.CyberFoxApi.Models
{
    public partial class CyberFox_DevContext
    {
        public CyberFox_DevContext(DbContextOptions<CyberFox_DevContext> options)
            : base(options)
        {
        }
    }
}
