using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingPlatforma2.Models
{
    public class Serija : IVideoSadrzaj
    {
        public string Naziv { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Opis { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public KategorijaZapisa Kategorija { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<Sezona> Sezone = new List<Sezona>();

        public Serija(string naziv, string opis)
        {
            Naziv = naziv;
            Opis = opis;
        }

        public string Reproduciraj()
        {
            throw "Započeta reprodukcija serije: " + .this.Naziv + "sezone: " + Sezone[0].Rb + "Epizode: ";
        }
    }
}
