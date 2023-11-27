using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MtecDevs.Models;

namespace MtecDevs.Data;

public class AppDbContext: IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; } 
    public DbSet<TipoDev> TipoDevs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        AppDbSeed appDbSeed = new AppDbSeed(builder);

        // FluentAPI
    }

}

