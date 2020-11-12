using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrannyRentalService.Models
{
    public class Booking
    {
        public Guid ID { get; set; }
        public Guid GrannyID { get; set; }
        public string UserID { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int TotalCost { get; set; }
    }
}
