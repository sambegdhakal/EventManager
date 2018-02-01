using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LFA.EventManager.Models
{
    public class EventManagerDbContext: DbContext
    {
        public EventManagerDbContext() : base("connString")
        {

        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
    }

}