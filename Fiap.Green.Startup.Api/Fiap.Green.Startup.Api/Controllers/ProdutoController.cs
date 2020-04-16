using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Green.Startup.Domain.Entities;
using Fiap.Green.Startup.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Green.Startup.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        public IActionResult Create([Bind("IdProduto,NomeProduto,Quantidade,Ativo,Preco,DataAtualizacao,IdTipoProduto,IdFornecedor")] Produto produto)
        {
            try
            {
                ProdutoBLL produtoBLL = new ProdutoBLL();
                produtoBLL.AdicionarProduto(produto);
                return Ok("Foi");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}