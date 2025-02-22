﻿using System.ComponentModel.DataAnnotations;

namespace OptionalUseCase.ViewModels
{
    // View Model for the Login 
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}