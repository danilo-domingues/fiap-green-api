using Fiap.Green.Startup.Domain.Entities;
using Fiap.Green.Startup.Repository.DAL;
using Fiap.Green.Startup.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fiap.Green.Startup.Service
{
    public class ProdutoBLL
    {
        readonly IProdutoRepository _produtoRepository;

        public ProdutoBLL()
        {
            try
            {
                //Cria uma instancia do repositorio Produto
                _produtoRepository = new ProdutoRepository();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Produto> Get_ProdutoInfo(int ID = -1)
        {
            try

            {
                if (ID == -1)
                {
                    //retorna todas as Produtos
                    return _produtoRepository.GetTodos().ToList();
                }
                else
                {
                    //retorna uma Produto pelo seu ID
                    return _produtoRepository.Get(p => p.IdProduto == ID).ToList();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AdicionarProduto(Produto cmp)
        {
            try
            {
                _produtoRepository.Adicionar(cmp);
                _produtoRepository.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Produto Localizar(int id)
        {
            try
            {
                return _produtoRepository.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirProduto(Produto cmp)
        {
            try
            {
                _produtoRepository.Deletar(c => c == cmp);
                _produtoRepository.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AlterarProduto(Produto emp)
        {
            try
            {
                _produtoRepository.Atualizar(emp);
                _produtoRepository.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
