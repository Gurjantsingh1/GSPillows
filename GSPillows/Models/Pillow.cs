using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSPillows.Models
{
    public class Pillow
    {
        public int Id { get; set; }
        public string Brand { get; set; }


        public string Size { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public int Rating { get; set; }

    }
}
