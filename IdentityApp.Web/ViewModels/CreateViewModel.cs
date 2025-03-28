﻿using System.ComponentModel.DataAnnotations;

namespace IdentityApp.Web.ViewModels
{
    public class CreateViewModel
    {
        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Girdiğiniz parolalar eşleşmiyor !")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
