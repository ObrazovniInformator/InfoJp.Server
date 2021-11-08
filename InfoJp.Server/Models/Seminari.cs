using System;
using System.Collections.Generic;

#nullable disable

namespace InfoJp.Server.Models
{
    public partial class Seminari
    {
        public Seminari()
        {
            PrijavaSeminars = new HashSet<PrijavaSeminar>();
        }

        public int Id { get; set; }
        public string NazivSeminara { get; set; }
        public string Slika { get; set; }

        public virtual ICollection<PrijavaSeminar> PrijavaSeminars { get; set; }
    }
}
