using System;
using System.Collections.Generic;

namespace Sansagol.CyberFox.CyberFoxApi.Models
{
    public partial class SnUser
    {
        public long IdSnUser { get; set; }
        public string SnUserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int IdSocialNetwork { get; set; }

        public SocialNetwork IdSocialNetworkNavigation { get; set; }
    }
}
