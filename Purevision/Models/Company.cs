namespace Purevision.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Company
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public int? ClientId { get; set; }

        public int? BusinessId { get; set; }

        public int? SortOrder { get; set; }

        public int? Level { get; set; }

        public DateTime? CreatedOnDate { get; set; }

        public int? CreatedByUserId { get; set; }

        public DateTime? UpdatedOnDate { get; set; }

        public int? UpdatedByUserId { get; set; }

        public DateTime? ArchivedOnDate { get; set; }

        public int? ArchivedByUserId { get; set; }
    }
}
