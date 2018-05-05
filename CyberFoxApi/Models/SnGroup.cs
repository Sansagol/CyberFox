using System;
using System.Collections.Generic;

namespace Sansagol.CyberFox.CyberFoxApi.Models
{
    public partial class SnGroup
    {
        public long IdSnGroup { get; set; }
        public int IdSocialNetwork { get; set; }
        public string SnGroupId { get; set; }
        public string Name { get; set; }

        public SocialNetwork IdSocialNetworkNavigation { get; set; }
    }
}
