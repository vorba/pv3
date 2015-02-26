namespace Purevision.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserProfile
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int PropertyId { get; set; }

        [StringLength(3750)]
        public string PropertyValue { get; set; }

        public string PropertyText { get; set; }

        public int Visibility { get; set; }

        public DateTime CreatedOnDate { get; set; }

        public int CreatedByUserId { get; set; }

        public DateTime UpdatedOnDate { get; set; }

        public int UpdatedByUserId { get; set; }

        public DateTime ArchivedOnDate { get; set; }

        public int ArchivedByUserId { get; set; }

        [StringLength(400)]
        public string ExtendedVisibility { get; set; }

        public virtual ProfileProperty ProfileProperty { get; set; }

        public virtual User User { get; set; }
    }
}
