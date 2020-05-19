using MpaFilteringAndSorting.ProductSelection.Models;
using MpaFilteringAndSorting.ProductSelection.Rules;
using MpaFilteringAndSorting.ProductSelection.Rules.Ntf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MpaFilteringAndSorting
{
    public class MpaRules
    {
        private readonly IEnumerable<IMpaFilterSortRule> _ntfRules;
        private readonly IEnumerable<IMpaFilterSortRule> _inAppRules;

        public MpaRules()
        {
            _ntfRules = new IMpaFilterSortRule[]
            {
                new NtfTeenRule(),
                new NtfAdultTopIncomeRule()
            };
        }

        public SortedAvailableProductSet GetAvailableProductsForNtf(AvailableProductsFilter filter)
        {
            var validRule = _ntfRules.FirstOrDefault(r => r.IsValid(filter));

            if (validRule == null)
            {
                throw new InvalidOperationException($"There is no valid available product rule that matches your filter parameters: age: {filter.Age}, income: {filter.MonthlyIncome}");
            }

            return validRule.ProductSet;
        }
    }
}
