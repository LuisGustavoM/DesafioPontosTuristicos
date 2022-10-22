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

            builder.HasData(
                new PontosTuristicos(
                    Guid.NewGuid(), 
                    "Cristo Redentor", 
                    "Principal ponto turístico do Rio de Janeiro",
                    "",
                    "Rio de Janeiro",
                    "RJ"
                 ),
                new PontosTuristicos(
                    Guid.NewGuid(),
                    "Pão de Açúcar",
                    "Principal ponto turístico do Rio de Janeiro",
                    "",
                    "Rio de Janeiro",
                    "RJ"
                 ),
                new PontosTuristicos(
                    Guid.NewGuid(),
                    "Cataratas do Iguaçu",
                    "Patrimonio Natural da Humanidade.",
                    "",
                    "Foz do Iguaçu",
                    "PR"
                 )
            );
        }
    }
}
