using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NorthWestLabs.Models
{
    public class WorkOrder
    {
        [Key]
        [Required(ErrorMessage = "Please enter a LT#")]
        [DisplayName("LT#")]
        [MinLength(6)]
        [MaxLength(6)]
        public int LTNum { get; set; }

        [Required(ErrorMessage = "Please enter a Customer Name")]
        [DisplayName("Customer")]
        [StringLength(30)]
        public string customerName { get; set; }

        [Required(ErrorMessage = "Please enter the date")]
        [DisplayName("Date Recieved")]
        public DateTime dateRecieved { get; set; }
    }
}