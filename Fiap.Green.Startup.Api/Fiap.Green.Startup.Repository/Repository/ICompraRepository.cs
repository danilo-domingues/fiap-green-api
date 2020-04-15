using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.Green.Startup.Domain.Entities;
using Fiap.Green.Startup.Repository.Context;

namespace Fiap.Green.Startup.Repository.Repository
{
    class ICompraRepository
    {
        void Inserir(Compra compra) 
        {
            OracleContext ctx = new OracleContext();
            ctx.Compra.Add(compra);
        }

    }
}
