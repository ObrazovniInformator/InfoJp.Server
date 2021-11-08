using System;
using System.Collections.Generic;

#nullable disable

namespace InfoJp.Server.Models
{
    public partial class Pretplatum
    {
        public int Id { get; set; }
        public DateTime? DatumPocetka { get; set; }
        public DateTime? DatumKraja { get; set; }
        public int? IdPretplatnik { get; set; }
        public int? IdPlacanje { get; set; }

        public virtual Placanje IdPlacanjeNavigation { get; set; }
        public virtual Pretplatnik IdPretplatnikNavigation { get; set; }
    }
}
