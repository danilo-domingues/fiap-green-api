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
        // GET: api/Default
        [HttpGet]
        public List<Produto> Get()
        {
            try
            {
                ProdutoBLL produtoBLL = new ProdutoBLL();
                List<Produto> lista = produtoBLL.Get_ProdutoInfo();
                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }

            }

        }
}