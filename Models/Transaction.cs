using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kuwaderno.Models
{
    public class Transaction
    {

        [Key]
        public int Id { get; set; }

        public virtual ApplicationUser BuyerUser { get; set; }
        public int BuyerId { get; set; }

        public virtual ApplicationUser SellerUser { get; set; }
        public int SellerId { get; set; }

        public string Request { get; set; }
        public string Review { get; set; } 
        public int? SatisfactionRating { get; set; }
        public bool RequestAccepted { get; set; }
        




    }
}
