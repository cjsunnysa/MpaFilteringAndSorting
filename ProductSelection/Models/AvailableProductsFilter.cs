using System;
using System.Collections.Generic;
using System.Text;

namespace MpaFilteringAndSorting.ProductSelection.Models
{
    public class AvailableProductsFilter
    {
        public int Age { get; }
        public int MonthlyIncome { get; }

        public AvailableProductsFilter(int age, int monthlyIncome)
        {
            Age = age;
            MonthlyIncome = monthlyIncome;
        }
    }
}
