using System;
using System.Collections.Generic;

#nullable disable

namespace InfoJp.Server.Models
{
    public partial class Urednici
    {
        public int Id { get; set; }
        public string ImeIprezime { get; set; }
        public string Oblast { get; set; }
        public string Slika { get; set; }
        public string SazetakBiografije { get; set; }
        public string Biografija { get; set; }
        public int RedniBroj { get; set; }
    }
}
