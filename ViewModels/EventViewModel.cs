using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LFA.EventManager.ViewModels
{
    public class EventViewModel
    {   
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.Html)]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EventDate { get; set; }
        
    }
}