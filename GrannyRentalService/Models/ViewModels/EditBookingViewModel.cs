using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrannyRentalService.Models.ViewModels
{
    public class EditBookingViewModel
    {
        public Booking Booking { get; set; }
        public List<Granny> Grannies { get; set; }
        public User User { get; set; }
    }
}
