using IdentityJwtApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityJwtApi.Data;

public class AppDbContext: IdentityDbContext<AppUser,AppRole,int>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}