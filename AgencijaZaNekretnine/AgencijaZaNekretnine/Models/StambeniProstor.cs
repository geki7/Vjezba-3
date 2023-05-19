using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Models
{
    public class StambeniProstor : IProstor
    {
        public string Vlasnik { get; set; }
        public string OzanakaProstora { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Slobodan { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ID_kata { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Kat KatProstora { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Prodaj(string kupac)
        {
            Slobodan = false;
            Vlasnik = kupac;
        }
    }
}
