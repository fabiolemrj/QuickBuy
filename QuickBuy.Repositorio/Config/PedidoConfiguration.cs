using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(x => x.Id);

            builder
              .Property(x => x.DataPedido)
              .IsRequired();
            builder
              .Property(x => x.DataPrevisaoEntrega)
              .IsRequired();
            builder
              .Property(x => x.CEP)
              .HasMaxLength(10)
              .IsRequired();
            builder
              .Property(x => x.Cidade)
              .HasMaxLength(100)
              .IsRequired();
            builder
              .Property(x => x.Estado)
              .HasMaxLength(100)
              .IsRequired();
            builder
              .Property(x => x.EnderecoCompleto)
              .HasMaxLength(100)
              .IsRequired();
            builder
             .Property(x => x.NumeroEndereco)
             .IsRequired();

            builder
                .HasMany(x => x.ItemPedidos)
                .WithOne(x => x.Pedido);
        }
    }
}
