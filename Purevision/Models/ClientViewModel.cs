﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Purevision.Web.Models
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
        public int? UserId { get; set; }

        public Person Person { get; set; }

        public virtual IQueryable<Person> People { get; set; }
        public virtual IQueryable<MeetingViewModel> Meetings { get; set; }
    }
}