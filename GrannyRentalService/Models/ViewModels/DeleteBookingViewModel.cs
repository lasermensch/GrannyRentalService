using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrannyRentalService.Models.ViewModels
{
    public class DeleteBookingViewModel
    {
        public Booking Booking { get; set; }
        public Granny Granny { get; set; }
        public User User { get; set; }
    }
}
