using MpaFilteringAndSorting.ProductSelection.Models;
using System;

namespace MpaFilteringAndSorting
{
    /* 
     * Rules categories:
     * [Flow][Age][Income]
     * 
     * Flow: Ntf/InApp
     * Age: Teen/YoungAdult/Adult
     * Income: LowIncome/MediumIncome/HighIncome/TopIncome
     * 
     * Naming a rule takes the following form:
     * [Ntf][YoungAdult][MediumIncome]
     * So name is: NtfYoungAdultMediumIncomeRule
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Retrieving valid products for 32 year old earning R70 000 monthly...");

            var age = 32;
            var monthlyIncome = 72000;

            
            var filter = new AvailableProductsFilter(age, monthlyIncome);
            
            var mpaRules = new MpaRules();

            var productsSet = mpaRules.GetAvailableProductsForNtf(filter);

            
            foreach (var product in productsSet.AvailableProducts)
            {
                Console.WriteLine($"Order: {product.OrderNo}, ProductCode: {product.ProductCode}");
            }

            Console.WriteLine("Retrieval complete.");
        }
    }
}
