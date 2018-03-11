using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sansagol.CyberFox.CyberFoxApi.Models
{
    public class AuthenticationResponseItem
    {
        public long UserId { get; set; }
        public string AccessToken { get; set; }
    }
}
