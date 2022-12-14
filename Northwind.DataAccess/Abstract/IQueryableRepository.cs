using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IQueryableRepository<T> where T : class, IEntity , new()
    {
        IQueryable<T> Table { get; }
    }
}
