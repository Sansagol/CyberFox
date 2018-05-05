using System;
using System.Collections.Generic;

namespace Sansagol.CyberFox.CyberFoxApi.Models
{
    public partial class SocialNetwork
    {
        public SocialNetwork()
        {
            SnGroup = new HashSet<SnGroup>();
            SnUser = new HashSet<SnUser>();
        }

        public int IdSocialNetwork { get; set; }
        public string Name { get; set; }
        public string TargetSite { get; set; }

        public ICollection<SnGroup> SnGroup { get; set; }
        public ICollection<SnUser> SnUser { get; set; }
    }
}
