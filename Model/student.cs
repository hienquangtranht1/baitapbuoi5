namespace b5.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("student")]
    public partial class student
    {
        [StringLength(20)]
        public string studentid { get; set; }

        [StringLength(100)]
        public string fullname { get; set; }

        public double? averagescore { get; set; }

        public int facltyid { get; set; }

        public virtual faculty faculty { get; set; }
    }
}
