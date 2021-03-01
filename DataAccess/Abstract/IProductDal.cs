using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}

// Code Refactoring
// Kod İyileştirilmesi