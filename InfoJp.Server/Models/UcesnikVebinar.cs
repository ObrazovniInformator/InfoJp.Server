using System;
using System.Collections.Generic;

#nullable disable

namespace InfoJp.Server.Models
{
    public partial class UcesnikVebinar
    {
        public UcesnikVebinar()
        {
            PrijavaVebinars = new HashSet<PrijavaVebinar>();
        }

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string RadnoMesto { get; set; }
        public string KontaktTelefon { get; set; }
        public string Email { get; set; }
        public int? IdPravnoLice { get; set; }

        public virtual PravnoLice IdPravnoLiceNavigation { get; set; }
        public virtual ICollection<PrijavaVebinar> PrijavaVebinars { get; set; }
    }
}
