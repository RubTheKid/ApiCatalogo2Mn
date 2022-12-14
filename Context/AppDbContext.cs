using ApiCatalogo2.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo2.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    //entities mapping
    public DbSet<Produto>? Produtos { get; set; }
    public DbSet<Categoria>? Categorias { get; set; }

    //overriding ef default conventions
    protected override void OnModelCreating(ModelBuilder mb)
    {

    }
}
