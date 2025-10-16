using Microsoft.AspNetCore.Identity;

namespace CCTVManagementSystem.Infrastructure.Entities;

public class AppUser : IdentityUser
{
    public string FullName { get; set; }
}