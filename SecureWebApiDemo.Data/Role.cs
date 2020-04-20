using Microsoft.AspNetCore.Identity;

namespace SecureWebAPIDemo.Data
{
    public class Role: IdentityRole<int>
    {
        public class Constants
        {
            public const string Lector = "lector";
            public const string Student = "student";
        }
    }
}
