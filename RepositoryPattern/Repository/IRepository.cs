using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.Entity;

namespace RepositoryPattern.Repository
{
    public interface IRepository<T> where T : EntityBase
    {
        public T GetById(int id);
        public void Create(T entity);
        public void Update(T entity);
        public void Delete(T entity);

    }
}
