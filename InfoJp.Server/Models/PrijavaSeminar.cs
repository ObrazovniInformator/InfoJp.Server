using System;
using System.Collections.Generic;

#nullable disable

namespace InfoJp.Server.Models
{
    public partial class PrijavaSeminar
    {
        public int Id { get; set; }
        public DateTime? DatumPrijave { get; set; }
        public string NacinPlacanja { get; set; }
        public int? IdSeminara { get; set; }
        public int? IdUcesnik { get; set; }

        public virtual Seminari IdSeminaraNavigation { get; set; }
        public virtual UcesnikSeminar IdUcesnikNavigation { get; set; }
    }
}
