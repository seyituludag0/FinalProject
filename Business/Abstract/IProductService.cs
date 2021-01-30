using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
