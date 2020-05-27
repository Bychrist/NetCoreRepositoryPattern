using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Repository.ContractsInterfaces
{
   public  interface IRepository <T> where T:class
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        void Update(T entity);

        void Delete(T entity);


    }
}
