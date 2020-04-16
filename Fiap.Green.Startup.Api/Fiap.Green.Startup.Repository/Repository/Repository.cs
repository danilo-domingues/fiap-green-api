using Fiap.Green.Startup.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Green.Startup.Repository.Repository
{
    public class Repository<T> : IRepository<T>, IDisposable where T : class
    {
        private readonly OracleContext ctx;

        protected Repository()
        {
            ctx = new OracleContext();
        }
        public IQueryable<T> GetTodos()
        {
            return ctx.Set<T>();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return ctx.Set<T>().Where(predicate);
        }

        public T Find(params object[] key)
        {
            return ctx.Set<T>().Find(key);
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            return ctx.Set<T>().Where(predicate).FirstOrDefault();
        }

        public void Adicionar(T entity)
        {
            ctx.Set<T>().Add(entity);
        }

        public void Atualizar(T entity)
        {
            ctx.Entry(entity).State = EntityState.Modified;
        }

        public void Deletar(Func<T, bool> predicate)
        {
            ctx.Set<T>()
           .Where(predicate).ToList()
           .ForEach(del => ctx.Set<T>().Remove(del));
        }

        public void Commit()
        {
            ctx.SaveChanges();
        }

        public void Dispose()
        {
            if (ctx != null)
            {
                ctx.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}

