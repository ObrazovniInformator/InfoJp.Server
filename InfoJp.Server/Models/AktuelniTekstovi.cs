using System;
using System.Collections.Generic;

#nullable disable

namespace InfoJp.Server.Models
{
    public partial class AktuelniTekstovi
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public DateTime? Datum { get; set; }
        public string Tekst { get; set; }
        public string Slika { get; set; }
    }
}
