namespace Purevision.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Business
    {
        public Business()
        {
            BusinessProfiles = new HashSet<BusinessProfile>();
        }

        public int Id { get; set; }

        public int PrincipleOwnerUserId { get; set; }

        public string Name { get; set; }

        [StringLength(10)]
        public string Number { get; set; }

        public virtual ICollection<BusinessProfile> BusinessProfiles { get; set; }
    }
}
