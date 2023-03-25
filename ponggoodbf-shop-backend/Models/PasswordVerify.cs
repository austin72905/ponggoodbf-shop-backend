using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace ponggoodbf_shop_backend.Models
{
    public class PasswordVerify
    {
        public string? oldPassword { get; set; }

        
        public string? newPassword { get; set; }

        public string? confirmNewPassword { get; set; }

    }
}
