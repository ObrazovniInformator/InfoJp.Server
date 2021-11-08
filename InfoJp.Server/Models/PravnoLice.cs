using System;
using System.Collections.Generic;

#nullable disable

namespace InfoJp.Server.Models
{
    public partial class PravnoLice
    {
        public PravnoLice()
        {
            UcesnikSeminars = new HashSet<UcesnikSeminar>();
            UcesnikVebinars = new HashSet<UcesnikVebinar>();
        }

        public int Id { get; set; }
        public string NazivPravnogLica { get; set; }
        public string PostanskiBrojImesto { get; set; }
        public string UlicaIbroj { get; set; }
        public string Pib { get; set; }
        public string TekuciRacun { get; set; }
        public string PoslovniMejlUstanove { get; set; }
        public string Faks { get; set; }
        public int? PretplatnickiStatus { get; set; }

        public virtual ICollection<UcesnikSeminar> UcesnikSeminars { get; set; }
        public virtual ICollection<UcesnikVebinar> UcesnikVebinars { get; set; }
    }
}
