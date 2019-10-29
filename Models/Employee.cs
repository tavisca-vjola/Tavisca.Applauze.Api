using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tavisca.Applauze.Api.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Uri PhotoUri { get; set; }
        public string Tribe { get; set; }
        public int Points { get; set; }

    }
}
