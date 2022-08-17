﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionSystem.View_Model.Identity_view_model
{
    public class RegisterViewModel
    {


        [Required]
        [Display(Name = "User Name ")]
        [StringLength(15, MinimumLength = 3)]
        public string  UserName { get; set; }
        [Required]
        [Display(Name = "Nick name")]
        [StringLength(15, MinimumLength = 3)]
        public string Nick_name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display]
        public string  password { get; set; }
        [Required]
        [Compare("password")]
        [DataType(DataType.Password)]
        public string  ConfirmPassword { get; set; }
        [Required]
        // [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Range(0, 999999999999)]
        [Required]
        [Display(Name = "The ID number")]
        public int TheIDnumber { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required]
        [Display(Name = "Mobile phone")]
        public int phone_Mobile { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public string gender { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birht")]
        public DateTime Birth_Date { get; set; }
        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }
        //[Required]
        //public string Roles { get; set; }
        public string sitkey { get; set; }
    }
}
