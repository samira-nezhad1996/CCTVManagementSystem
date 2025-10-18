using Microsoft.AspNetCore.Identity;

namespace CCTVManagementSystem.Domain.Entities;

public class UserEntity : IdentityUser<string>
{
    public string FullName { get; set; }
}