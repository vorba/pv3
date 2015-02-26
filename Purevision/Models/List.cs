namespace Purevision.Web.Models.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class List
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Value { get; set; }

        [Required]
        [StringLength(150)]
        public string Text { get; set; }

        public int ParentId { get; set; }

        public int Level { get; set; }

        public int SortOrder { get; set; }

        public int DefinitionId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool IsSystem { get; set; }

        public DateTime? CreatedOnDate { get; set; }

        public int? CreatedByUserId { get; set; }

        public DateTime? UpdatedOnDate { get; set; }

        public int? UpdatedByUserId { get; set; }

        public DateTime? ArchivedOnDate { get; set; }

        public int? ArchivedByUserId { get; set; }
    }
}
