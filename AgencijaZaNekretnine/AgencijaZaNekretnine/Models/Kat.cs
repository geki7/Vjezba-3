using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Models
{
    public class Kat 
    {
        public int BrojKata { get; set; }
        public List<IProstor> Prostor = new List<IProstor>();
        public int ID { get; set; }
    }
}
