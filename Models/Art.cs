﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kuwaderno.Models
{
    public class Art
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string UserId { get; set; }
        public string Genre { get; set; }
        
    }
}
