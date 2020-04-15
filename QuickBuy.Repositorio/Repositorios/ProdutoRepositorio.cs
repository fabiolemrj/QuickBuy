using QuickBuy.Dominio.Contratos;
using QuickBuy.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(QuickBuyContext quickBuyContext) : base(quickBuyContext)
        {
        }
    }
}
