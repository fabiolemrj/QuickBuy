using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contratos;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.GetBaseException().ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            try
            {
                _produtoRepositorio.Adicionar(produto);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.GetBaseException().Message.ToString());
            }
        }
    }
}