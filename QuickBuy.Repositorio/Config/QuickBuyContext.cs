using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class QuickBuyContext: DbContext
    {
     

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public QuickBuyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(new FormaPagamento() { Id = 1, Descricao = "Forma de pagamento Boleto",Nome="Boleto" },
                new FormaPagamento() { Id = 2, Nome = "Cartao de Credito", Descricao="Forma de pagamento cartão de credito"},
                new FormaPagamento() { Id = 3, Nome = "Deposito", Descricao = "Forma de pagamento deposito" });
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
