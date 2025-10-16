using Microsoft.EntityFrameworkCore;
using CCTVManagementSystem.Infrastructure.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CCTVManagementSystem.Infrastructure.Data;

public class SqlServerContext :IdentityDbContext<UserEntity, RoleEntity, string>
{
    public SqlServerContext(DbContextOptions<SqlServerContext> options)
        : base(options)
    {
        
    }
}