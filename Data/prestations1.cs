namespace GestionHotel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.prestations")]
    public partial class prestations1
    {
        public int? reservationid { get; set; }

        public DateTime date_consommation { get; set; }

        public double prix_prestation { get; set; }

        public int id { get; set; }

        [StringLength(8000)]
        public string description { get; set; }

        [StringLength(8000)]
        public string type_prestation { get; set; }

        public virtual reservations1 reservations1 { get; set; }
    }
}
