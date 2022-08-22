using Microsoft.EntityFrameworkCore;

namespace PatrimonioSenaiTaguatinga.EntityConfiguration;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuario");
        builder.HasKey(u=>u.IdUsuario);
        builder.Property(u=>u.)
    }
}