namespace Purevision.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client
    {
        public Client()
        {
            ClientProfiles = new HashSet<ClientProfile>();
        }

        public int Id { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

        public int? UserId { get; set; }

        public virtual ICollection<ClientProfile> ClientProfiles { get; set; }
    }
}
