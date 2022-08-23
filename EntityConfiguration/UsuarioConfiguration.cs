using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PatrimonioSenaiTaguatinga.Entities;

namespace PatrimonioSenaiTaguatinga.EntityConfiguration;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuario");
        builder.HasKey(u=>u.IdUsuario);
        builder.Property(u=>u.Nome).IsRequired().HasMaxLength(50);
        builder.Property(u=>u.Sobrenome).IsRequired().HasMaxLength(50);
        builder.Property(u=>u.Login).IsRequired().HasMaxLength(30);
        builder.Property(u=>u.Senha).IsRequired().HasMaxLength(10);
        builder.Property(u=>u.IdNivel).IsRequired();
        builder.HasOne(u=>u.Nivel).WithMany(n=>n.Usuarios).HasForeignKey(u=>u.IdNivel);
        
    }
}