//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Purevision.Web.Models.OldModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.UserProfiles = new HashSet<UserProfile>();
        }
    
        public int Id { get; set; }
        public string AspNetUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public int CreatedByUserId { get; set; }
        public System.DateTime CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserId { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
