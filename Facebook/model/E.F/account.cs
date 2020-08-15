namespace model.E.F
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account")]
    public partial class account
    {
        [Key]
        [Column("user id")]
        public int user_id { get; set; }

        [StringLength(50)]
        public string user_account { get; set; }

        [StringLength(50)]
        public string user_pass { get; set; }
    }
}
