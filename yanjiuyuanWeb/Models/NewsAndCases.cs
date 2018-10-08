namespace yanjiuyuanWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NewsAndCases
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [StringLength(100)]
        public string Type { get; set; }

        [StringLength(500)]
        public string ImageUrl { get; set; }

        [StringLength(300)]
        public string Title { get; set; }

        [StringLength(300)]

        public string Contents { get; set; }

        [StringLength(100)]
        public string CreateTime { get; set; }

        [StringLength(100)]
        public string BigType { get; set; }

        [StringLength(200)]
        public string Abstract { get; set; }
    }
}
