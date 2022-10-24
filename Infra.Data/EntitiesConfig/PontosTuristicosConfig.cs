using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntitiesConfig
{
    public class PontosTuristicosConfig: IEntityTypeConfiguration<PontosTuristicos>
    {
        public void Configure(EntityTypeBuilder<PontosTuristicos> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Descricao).HasMaxLength(100).IsRequired();
        }
    }
}
