using System;
using System.Collections.Generic;

#nullable disable

namespace InfoJp.Server.Models
{
    public partial class Vebinari
    {
        public Vebinari()
        {
            PrijavaVebinars = new HashSet<PrijavaVebinar>();
        }

        public int Id { get; set; }
        public string NaizvVebinara { get; set; }
        public string Slika { get; set; }

        public virtual ICollection<PrijavaVebinar> PrijavaVebinars { get; set; }
    }
}
