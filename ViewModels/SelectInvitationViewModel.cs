using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LFA.EventManager.ViewModels
{
    public class SelectInvitationViewModel
    {
        public IEnumerable<SelectListItem> Contacts { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; }
        public bool Invite { get; set; }

    }
}