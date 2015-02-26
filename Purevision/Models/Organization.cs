using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Purevision.Web.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Organization
    {
        public Organization()
        {
            People = new HashSet<Person>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int? PersonId { get; set; }
        public int? BusinessId { get; set; }
        public int? SortOrder { get; set; }
        public int? Level { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? UpdatedOnDate { get; set; }
        public int? UpdatedByUserId { get; set; }
        public DateTime? ArchivedOnDate { get; set; }
        public int? ArchivedByUserId { get; set; }

        public virtual ICollection<Person> People { get; set; }
        public virtual Business Businesses { get; set; }
    }
}