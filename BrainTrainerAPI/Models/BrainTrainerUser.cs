using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainTrainerAPI.Models
{
    public class BrainTrainerUser
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }

    }
}
