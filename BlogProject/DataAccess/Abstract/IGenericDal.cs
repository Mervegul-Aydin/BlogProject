﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGenericDal <T> where T : class
    {
        void Add(T entity);
        void Delete (T entity);
        void Update (T entity);
        List<T> GetListAll ();
        T GetByID(int id);
    }
}
