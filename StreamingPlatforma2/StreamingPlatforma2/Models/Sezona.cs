using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingPlatforma2.Models
{
    public class Sezona
    {
        public int Rb { get; set; }
        public int IDSerije { get; set; }
        public int ID { get; set; }
        public List<Epizoda> Epizode;
    }
}
