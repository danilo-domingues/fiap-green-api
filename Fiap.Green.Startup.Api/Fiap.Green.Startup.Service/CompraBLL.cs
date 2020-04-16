using Fiap.Green.Startup.Domain.Entities;
using Fiap.Green.Startup.Repository.DAL;
using Fiap.Green.Startup.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fiap.Green.Startup.Service
{
    public class CompraBLL
    {
        readonly ICompraRepository _compraRepository;

        public CompraBLL()
        {
            try
            {
                //Cria uma instancia do repositorio Compra
                _compraRepository = new CompraRepository();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Compra> Get_CompraInfo(int ID = -1)
        {
            try

            {
                if (ID == -1)
                {
                    //retorna todas as Compras
                    return _compraRepository.GetTodos().ToList();
                }
                else
                {
                    //retorna uma compra pelo seu ID
                    return _compraRepository.Get(p => p.IdCompra == ID).ToList();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AdicionarCompra(Compra cmp)
        {
            try
            {
                _compraRepository.Adicionar(cmp);
                _compraRepository.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Compra Localizar(int id)
        {
            try
            {
                return _compraRepository.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirCompra(Compra cmp)
        {
            try
            {
                _compraRepository.Deletar(c => c == cmp);
                _compraRepository.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AlterarCompra(Compra emp)
        {
            try
            {
                _compraRepository.Atualizar(emp);
                _compraRepository.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
