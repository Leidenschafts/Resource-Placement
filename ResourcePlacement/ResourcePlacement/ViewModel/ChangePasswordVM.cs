﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResourcePlacement.ViewModel
{
    public class ChangePasswordVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
    
        public string OldPassword { get; set; }
        [Required]
       
        public string NewPassword { get; set; }
        [Required]
       
        public string NewPasswordConfirm { get; set; }
    }
}
