using System;
using System.Collections.Generic;

#nullable disable

namespace InfoJp.Server.Models
{
    public partial class KalendarObaveza
    {
        public int Id { get; set; }
        public string NaslovniDatum { get; set; }
        public string KorisnikOrgan { get; set; }
        public string Obaveza { get; set; }
        public string OsnovPropis { get; set; }
    }
}
