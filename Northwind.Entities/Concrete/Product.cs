using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities.Concrete
{
    public class Product:IEntity
    {
        public virtual int ProductID { get; set; }
        public virtual Int32? CategoryID { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string QuantityPerUnit { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual Int16 UnitsInStock { get; set; }
    }
}
