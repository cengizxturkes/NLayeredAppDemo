using Northwind.Business.Abstract;
using Northwind.DataAcces.Abstract;
using Northwind.DataAcces.Concrete;
using Northwind.DataAcces.Concrete.EntityFramework;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;
      public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
