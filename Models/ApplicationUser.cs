using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kuwaderno.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        public string FirtName { get; set; }
        public string LastName { get; set; }

        public string Instagram { get; set; }

        public string ProfilePicture { get; set; }

        public string Background { get; set; }
        
    }
}
