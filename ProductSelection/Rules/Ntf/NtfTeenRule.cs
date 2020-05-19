using MpaFilteringAndSorting.ProductSelection.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MpaFilteringAndSorting.ProductSelection.Rules.Ntf
{
    public class NtfTeenRule : IMpaFilterSortRule
    {
        public SortedAvailableProductSet ProductSet { get; }

        public bool IsValid(AvailableProductsFilter request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return 
                request.Age >= 16
                && request.Age <= 17;
        }

        public NtfTeenRule()
        {
            var products = new AvailableProduct[]
            {
                new AvailableProduct(1, "STUDENT")
            };

            ProductSet = new SortedAvailableProductSet(products);
        }
    }
}
