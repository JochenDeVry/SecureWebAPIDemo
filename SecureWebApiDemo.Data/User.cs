using Microsoft.AspNetCore.Identity;
using System;

namespace SecureWebAPIDemo.Data
{
    public class User: IdentityUser<int>
    {
        public DateTime DateOfBirth { get; set; }
    }
}
