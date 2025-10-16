using Microsoft.AspNetCore.Identity;

namespace CCTVManagementSystem.Infrastructure.Entities;

public class UserEntity : IdentityUser
{
    public string FullName { get; set; }
}