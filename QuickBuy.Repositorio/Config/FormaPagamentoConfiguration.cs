using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(x => x.Id);

            builder
             .Property(x => x.Nome)
             .HasMaxLength(50)
             .IsRequired();
            builder
             .Property(x => x.Descricao)
             .HasMaxLength(100)
             .IsRequired();
        }
    }
}
