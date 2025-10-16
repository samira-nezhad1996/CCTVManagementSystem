using Microsoft.EntityFrameworkCore;
using CCTVManagementSystem.Infrastructure.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CCTVManagementSystem.Infrastructure.Data;

public class AppDbContext :IdentityDbContext<AppUser, AppRole, string>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        
    }
}