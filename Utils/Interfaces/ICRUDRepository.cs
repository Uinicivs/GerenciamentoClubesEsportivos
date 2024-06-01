using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoClubesEsportivos.Utils.Interfaces
{
    internal interface ICRUDRepository<T>
    {
        List<T> GetAll();
        List<T> Search(string query);
        T GetByID(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
