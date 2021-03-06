﻿using BTProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTProject.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<ApplicationUser> AssignedUsers { get; set; }
    }
}