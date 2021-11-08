using System;
using System.Collections.Generic;

#nullable disable

namespace InfoJp.Server.Models
{
    public partial class Placanje
    {
        public Placanje()
        {
            Pretplata = new HashSet<Pretplatum>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Pretplatum> Pretplata { get; set; }
    }
}
