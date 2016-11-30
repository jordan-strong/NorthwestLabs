using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/*This page is the model for the CRM account. It would be a mix of different tables in the database*/

namespace NorthWestLabs.Models
{
    public class CRM
    {
        [Key]
        [Required(ErrorMessage = "Please enter a customer ID")]
        [DisplayName("Customer ID")]
        public int customerID { get; set; }

        [Required(ErrorMessage = "Please enter a Customer Name")]
        [DisplayName("Customer")]
        [StringLength(30)]
        public string customerName { get; set; }

        [Required(ErrorMessage = "Please enter the billing address")]
        [DisplayName("Billing Address")]
        public DateTime billingAddress { get; set; }

        [Required(ErrorMessage = "Please enter the billing city")]
        [DisplayName("City")]
        public DateTime city { get; set; }

        [Required(ErrorMessage = "Please enter the billing state")]
        [DisplayName("State")]
        public DateTime state { get; set; }

        [Required(ErrorMessage = "Please enter the billing zip code")]
        [DisplayName("ZIP")]
        public DateTime ZIP { get; set; }

        [Required(ErrorMessage = "Please enter the contact first name")]
        [DisplayName("Contact First Name")]
        public DateTime contactFirstName { get; set; }

        [Required(ErrorMessage = "Please enter the contact last name")]
        [DisplayName("Contact Last Name")]
        public DateTime contactLastName { get; set; }

        [Required(ErrorMessage = "Please enter the contact phone number")]
        [DisplayName("Contact Phone Number")]
        public DateTime contactPhone { get; set; }

        [Required(ErrorMessage = "Please enter the contact email")]
        [DisplayName("Contact Email")]
        public DateTime contactEmail { get; set; }
    }

}