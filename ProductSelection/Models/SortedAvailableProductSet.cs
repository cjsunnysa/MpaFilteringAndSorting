using MpaFilteringAndSorting.ProductSelection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MpaFilteringAndSorting.ProductSelection.Models
{
    public class SortedAvailableProductSet
    {
        private readonly IEnumerable<AvailableProduct> _products;

        public IEnumerable<AvailableProduct> AvailableProducts => _products.OrderBy(p => p.OrderNo);

        public SortedAvailableProductSet(IEnumerable<AvailableProduct> products)
        {
            _products = products ?? throw new ArgumentNullException(nameof(products));
        }
    }
}
