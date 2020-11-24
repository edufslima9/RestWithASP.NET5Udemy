﻿using RestWithASPNETUdemy.Model.Base;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T entity);
        T FindById(long id);
        List<T> FindAll();
        T Update(T entity);
        void Delete(long id);
        bool Exists(long id);
    }
}
