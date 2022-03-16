using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace InfoJp.Server.Models
{
    public partial class Vesti
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? Datum { get; set; }
        public string Teskst { get; set; }
        public string Slika { get; set; }
    }
}
