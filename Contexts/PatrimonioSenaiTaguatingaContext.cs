using Microsoft.EntityFrameworkCore;
using PatrimonioSenaiTaguatinga.Entities;
using PatrimonioSenaiTaguatinga.EntityConfiguration;

namespace PatrimonioSenaiTaguatinga.Contexts;

public class PatrimonioSenaiTaguatingaContext:DbContext{
    private readonly IConfiguration _configuration;
public PatrimonioSenaiTaguatingaContext(IConfiguration configuration){
    _configuration = configuration;

}

public DbSet<Nivel> Nivel => Set<Nivel>();
public DbSet<Usuario> Usuario => Set<Usuario>();

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
    optionsBuilder.UseSqlServer(_configuration.GetConnectionString("PatrimonioSenaiTaguatinga"));
}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new NivelConfiguration());
        modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
    }

}
