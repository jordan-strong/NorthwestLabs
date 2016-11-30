using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NorthWestLabs.Models
{
    public class Sales
    {
        [Key]
        [Required(ErrorMessage = "Please choose an assay")]
        [DisplayName("Assay requested:")]
        public string assay { get; set; }

        [Required(ErrorMessage = "Please enter a compound")]
        [DisplayName("Compound:")]
        [StringLength(30)]
        public string compound { get; set; }
    }
}