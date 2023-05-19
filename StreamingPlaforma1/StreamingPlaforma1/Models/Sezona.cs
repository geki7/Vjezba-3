using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingPlaforma1.Models
{
    public class Sezona
    {
        public int Rb { get; set; }
        public List<Epizoda> Epizode = new List<Epizoda>();

        public Sezona()
        {

        }
    }
}
