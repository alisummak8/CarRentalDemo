using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICheckEntityService<T> where T : class, IEntity, new()
    {
        void CheckAndAdd(T entity);
        void CheckAndUpdate(T entity);
    }
}
