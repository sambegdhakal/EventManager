using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LFA.EventManager.Models
{
    public class Select
    {
        public IEnumerable<Contact> Contact { get; set; }
        public int ContactId{ get; set; }
    }
}