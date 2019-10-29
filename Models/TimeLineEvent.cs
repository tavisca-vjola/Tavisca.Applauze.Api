using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tavisca.Applauze.Api.Models
{
    public class TimeLineEvent
    {
        public string Id { get; set; }
        public Uri Logo { get; set; }
        public DateTime TimeStamp { get; set; }
        // Either Activity or Reward or BadgeUpgradations
        public string EventType { get; set; }
    }
}
