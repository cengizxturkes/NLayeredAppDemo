using Northwind.DataAcces.Abstract;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAcces.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
            {
                new Product{ProductID=1,
                    CategoryID=1,
                    ProductName="Laptop",
                    QuantityPerUnit="1 in abox",
                    UnitPrice=3000,UnitsInStock=11}
            };
            return products;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
