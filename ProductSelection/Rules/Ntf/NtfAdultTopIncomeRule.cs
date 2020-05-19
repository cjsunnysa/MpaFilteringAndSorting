using MpaFilteringAndSorting.ProductSelection.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MpaFilteringAndSorting.ProductSelection.Rules.Ntf
{
    class NtfAdultTopIncomeRule : IMpaFilterSortRule
    {
        public SortedAvailableProductSet ProductSet { get; }

        public bool IsValid(AvailableProductsFilter request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return
                request.Age >= 27
                && request.MonthlyIncome >= 62500;
        }

        public NtfAdultTopIncomeRule()
        {
            var products = new AvailableProduct[]
            {
                new AvailableProduct(1, "PROFESSIONAL_ONE"),
                new AvailableProduct(2, "PROFESSIONAL_BUNDLE"),
                new AvailableProduct(3, "YOUNG_PROFESSIONAL_ONE"),
                new AvailableProduct(4, "PROFESSIONAL"),
                new AvailableProduct(5, "SAVVY_BUNDLE")
            };

            ProductSet = new SortedAvailableProductSet(products);
        }
    }
}
