using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Contratos
{
    public class Pedido:Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public TipoFormaPagamentoEnum TipoFormaPagamento { get; set; }
        public ICollection<ItemPedido> ItemPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItemPedidos.Any())
                AdicionarCritica("Não existe item do pedido");


            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("CEP deve estar preenchido");

        }
    }
}
