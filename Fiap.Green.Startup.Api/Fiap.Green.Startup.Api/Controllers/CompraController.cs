using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Fiap.Green.Startup.Domain.Entities;
using Fiap.Green.Startup.Service;

namespace Fiap.Green.Startup.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("IdCompra,IdProduto,IdTipoProduto,IdEmpresa,IdTipoPagamento,Preco,Ordem")] Compra compra)
        {
            try
            {
                CompraBLL compraBLL = new CompraBLL();
                compraBLL.AdicionarCompra(compra);
                return Ok("Foi");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}