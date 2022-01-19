using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AdminPanel.Models
{

    public class CustDB
    {
        [Required, StringLength(200), Display(Name = "ID")]
        public string ID { get; set; }

        [Required, StringLength(200), Display(Name = "Case")]
        public string Case { get; set; }

        [Required, StringLength(200), Display(Name = "First name")]
        public string FName { get; set; }

        [Required, StringLength(200), Display(Name = "Last Name")]
        public string LName { get; set; }

        [Required, StringLength(200), Display(Name = "Number")]
        public string Number { get; set; }

        [Required, StringLength(200), Display(Name = "Email")]
        public string Email { get; set; }

        [Required, StringLength(200), Display(Name = "City")]
        public string City { get; set; }

        [Required, StringLength(200), Display(Name = "Country")]
        public string IsActive { get; set; }

        [Required, StringLength(200), Display(Name = "Age")]
        public string Age { get; set; }

        [Required, StringLength(200), Display(Name = "StateUt")]
        public string StateUT { get; set; }

        [Required, StringLength(200), Display(Name = "AccType")]
        public string AccType { get; set; }

        [Required, StringLength(200), Display(Name = "Password")]
        public string Password { get; set; }

        [Required, StringLength(200), Display(Name = "UName")]
        public string UName { get; set; }
    }
}