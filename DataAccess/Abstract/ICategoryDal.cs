using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
