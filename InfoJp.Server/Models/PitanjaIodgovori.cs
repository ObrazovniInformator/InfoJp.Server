using System;
using System.Collections.Generic;

#nullable disable

namespace InfoJp.Server.Models
{
    public partial class PitanjaIodgovori
    {
        public int Id { get; set; }
        public string Pitanje { get; set; }
        public string Odgovor { get; set; }
    }
}
