using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
       void Add(Product product);

        List<Product> GetAll();
        List<Product> GetProductsByProductName(string text);
        List<Product> GetByCategory(int categoryID);
        void Delete(Product product);
        void Update(Product product);
    }
}
