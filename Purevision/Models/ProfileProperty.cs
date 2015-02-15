namespace Purevision.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProfileProperty
    {
        public ProfileProperty()
        {
            BusinessProfiles = new HashSet<BusinessProfile>();
            ClientProfiles = new HashSet<ClientProfile>();
            UserProfiles = new HashSet<UserProfile>();
        }

        public int Id { get; set; }

        public int DataType { get; set; }

        [Column(TypeName = "ntext")]
        public string Default { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Length { get; set; }

        public bool Required { get; set; }

        [StringLength(2000)]
        public string Validation { get; set; }

        public int Order { get; set; }

        public bool Visible { get; set; }

        public DateTime? CreatedOnDate { get; set; }

        public int? CreatedByUserID { get; set; }

        public DateTime? UpdatedOnDate { get; set; }

        public int? UpdatedByUserID { get; set; }

        public DateTime? ArchivedOnDate { get; set; }

        public int? ArchivedByUserID { get; set; }

        public int? DefaultVisibility { get; set; }

        public bool ReadOnly { get; set; }

        public virtual ICollection<BusinessProfile> BusinessProfiles { get; set; }

        public virtual ICollection<ClientProfile> ClientProfiles { get; set; }

        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
