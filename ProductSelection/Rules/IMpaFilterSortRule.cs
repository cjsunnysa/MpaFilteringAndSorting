using MpaFilteringAndSorting.ProductSelection.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MpaFilteringAndSorting.ProductSelection.Rules
{
    public interface IMpaFilterSortRule
    {
        SortedAvailableProductSet ProductSet { get; }
        bool IsValid(AvailableProductsFilter request);
    }
}
