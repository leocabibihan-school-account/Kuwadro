using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kuwaderno.Models
{
    public class ProfilePageModel
    {
        public List<Art> ArtList { get; set; }

        public ApplicationUser User { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
