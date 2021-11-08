using System;
using System.Collections.Generic;

#nullable disable

namespace InfoJp.Server.Models
{
    public partial class Pretplatnik
    {
        public Pretplatnik()
        {
            Pretplata = new HashSet<Pretplatum>();
        }

        public int Id { get; set; }
        public string NazivPravnogLica { get; set; }
        public string PostanskiBrojImesto { get; set; }
        public string UlicaIbroj { get; set; }
        public string Pib { get; set; }
        public string TekuciRacun { get; set; }
        public string EmailPravnogLica { get; set; }
        public string Telefon { get; set; }
        public string Faks { get; set; }
        public string EmailRukovodioca { get; set; }
        public string EmailPravnika { get; set; }
        public string EmailEkonomiste { get; set; }

        public virtual ICollection<Pretplatum> Pretplata { get; set; }
    }
}
