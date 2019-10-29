using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tavisca.Applauze.Api.Models
{
    public class EmployeeAchievementStats
    {
        public string Id { get; set; }
        public int NumberofKudos { get; set; }
        public int NumberofShoutouts { get; set; }
        public int NumberofRewards { get; set; }
        public string BadgeType { get; set; }
    }
}
