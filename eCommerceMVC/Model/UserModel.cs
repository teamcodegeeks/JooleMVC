using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace eCommerceMVC.Model
{
    public class UserModel
    {
        public int UserID { get; set; }

        [Required (ErrorMessage = "Please enter user name!")]
        [StringLength(maximumLength: 7, MinimumLength = 3, ErrorMessage = "Username length Must be Maximum 7 nad minimum 3!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter the Password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter the Confirm Password!")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirmpassword { get; set; }

        [Required(ErrorMessage = "Please enter the email Address!")]
        public string Email { get; set; }

        public byte UserRoleId { get; set; }

        [Required(ErrorMessage = "Upload Profile Image!")]
        public string Picture { get; set; }

        public string RoleDescription { get; set; }
    }
}