namespace Purevision.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public User()
        {
            UserProfiles = new HashSet<UserProfile>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string AspNetUserId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(256)]
        public string DisplayName { get; set; }

        [Required]
        [StringLength(256)]
        public string Email { get; set; }

        public int CreatedByUserId { get; set; }

        public DateTime CreatedOnDate { get; set; }

        public int? LastModifiedByUserId { get; set; }

        public DateTime? LastModifiedOnDate { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
