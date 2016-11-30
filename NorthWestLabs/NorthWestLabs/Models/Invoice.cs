using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWestLabs.Models
{
    //this code creates a model for an invoice and tells the user what attributes are required or allowed for an invoice 
    public class Invoice
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        [DisplayName("Invoice ID")]
        public int invoiceID { get; set; }

        [Required(ErrorMessage = "Please enter the total price")]
        [DisplayName("Total Price of Invoice")]
        public double totalPrice { get; set; }

        [DisplayName("Payment Terms")]
        public string paymentTerms { get; set; }

        
        [DisplayName("Print Date")]
        public DateTime printDate { get; set; }

        [Required(ErrorMessage = "Please enter a company id")]
        [DisplayName("Company ID")]
        public int companyID { get; set; }

        [Required(ErrorMessage = "Please enter an employee ID")]
        [DisplayName("Employee ID")]
        public int employeeID { get; set; }

        [Required(ErrorMessage = "Please enter a LT Number")]
        [DisplayName("LT Number")]
        [MinLength(6)]
        [MaxLength(6)]
        public int LTNum { get; set; }




    }
}