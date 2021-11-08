using System;
using System.Collections.Generic;

#nullable disable

namespace InfoJp.Server.Models
{
    public partial class PrijavaVebinar
    {
        public int Id { get; set; }
        public DateTime? DatumPrijave { get; set; }
        public string NacinPlacanja { get; set; }
        public int? IdVebinara { get; set; }
        public int? IdUcesnika { get; set; }

        public virtual UcesnikVebinar IdUcesnikaNavigation { get; set; }
        public virtual Vebinari IdVebinaraNavigation { get; set; }
    }
}
