using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GrannyRentalService.Models
{
    public class Granny
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int HourlyRate { get; set; }
        public Guid ID { get; set; }
        //public Bitmap Picture { get; set; }

    }
}
