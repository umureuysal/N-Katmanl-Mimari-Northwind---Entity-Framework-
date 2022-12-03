using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class EfProductManager : IProductService
    {
        private IProductDal _productDal;

        public EfProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
             _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetByCategory(int categoryID)
        {
            return _productDal.GetAll(p => p.CategoryID ==categoryID);
        }

        public List<Product> GetProductsByProductName(string text)
        {
            return _productDal.GetAll(p=>p.ProductName.ToLower().Contains(text.ToLower()));
        }

        public void Update(Product product)
        {
             _productDal.Update(product);
        }
    }
}
