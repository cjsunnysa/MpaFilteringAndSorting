using System;
using System.Collections.Generic;
using System.Text;

namespace MpaFilteringAndSorting.ProductSelection.Models
{
    public class AvailableProduct
    {
        public int OrderNo { get; }
        public string ProductCode { get; }

        public AvailableProduct(int orderNo, string productCode)
        {
            OrderNo = orderNo;
            ProductCode = productCode;
        }
    }
}
