using System;
using System.Collections.Generic;

#nullable disable

namespace InfoJp.Server.Models
{
    public partial class Vesti
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public DateTime? Datum { get; set; }
        public string Teskst { get; set; }
        public string Slika { get; set; }
    }
}
