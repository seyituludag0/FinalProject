using Core;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Dtos
{
    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public int UnitsInStock { get; set; }
    }
}
