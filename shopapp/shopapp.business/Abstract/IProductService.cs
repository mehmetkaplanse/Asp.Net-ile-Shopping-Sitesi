using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.business.Abstract;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);

        List<Product> GetAll();

        void Create(Product entity);

        void Update(Product entity);
        void Delete(Product entity);
    }
}