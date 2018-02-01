using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LFA.EventManager.Models
{
    public class Invitation
    {
        public int Id { get; set; }
        public Event @event { get; set; }
        public int EventId { get; set; }
        public Contact contact { get; set; }
        public int ContactId { get; set; }
        public DateTime InviteDate { get; set; }
        public bool Status { get; set; }
    }
}