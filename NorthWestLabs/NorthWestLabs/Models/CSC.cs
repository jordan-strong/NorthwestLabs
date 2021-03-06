﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NorthWestLabs.Models
{
    public class CSC
    {
        [Key]
        [Required(ErrorMessage = "Please enter a CSC#")]
        [DisplayName("CSC#")]
        public int csc { get; set; }

        [Key]
        [Required(ErrorMessage = "Please enter a Assay#")]
        [DisplayName("Assay#")]
        public int assay { get; set; }

        [Required(ErrorMessage = "Please enter a compound weight in grams")]
        [DisplayName("Client Weight(g)")]
        public decimal weight { get; set; }

        [DisplayName("Actual Weight(g)")]
        public decimal actualWeight { get; set; }

        [DisplayName("Molecular Mass(g)")]
        public decimal molMass { get; set; }

        [DisplayName("MTD(g)")]
        public decimal mtd { get; set; }

        [Required(ErrorMessage = "Please enter a physical description of the appearance")]
        [DisplayName("Physical Description")]
        public string appearance { get; set; }

        [DisplayName("Passed Test")]
        public bool passedTest { get; set; }

        [DisplayName("Total Hours Tested")]
        public int hoursWorked { get; set; }

        [DisplayName("EmployeeID")]
        public int employeeID { get; set; }
    }
}