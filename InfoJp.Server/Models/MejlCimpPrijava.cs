using System;
using System.Collections.Generic;

#nullable disable

namespace InfoJp.Server.Models
{
    public partial class MejlCimpPrijava
    {
        public int Id { get; set; }
        public string ImeUstanove { get; set; }
        public string Email { get; set; }
        public DateTime? Datum { get; set; }
    }
}
