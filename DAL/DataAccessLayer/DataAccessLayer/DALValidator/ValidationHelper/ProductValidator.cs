using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForTheLogic.DALValidator.ValidationHelper
{
    /// <summary>
    /// Product Validator
    /// Team: DB
    /// Helper class for DALValidator. 
    /// This class contains all the validation rules for Product.
    /// 
    /// Author: Sean
    /// Date: 2017-12-01
    /// Update: Changed visibility to public for testing purposes
    /// 
    /// <para> Author: Bill </para>
    /// Date: 2017-11-12
    /// Based on: N/A   
    /// Update: N/A
    /// </summary>
    public class ProductValidator
    {
        /// <summary>
        /// Product Name Validator
        /// 
        /// Validation Rules:
        ///     1. product name can not be null
        ///     2. product name can not be empty
        ///     3. product name can not be longer than 30 letters 
        /// <para> Author: Bill </para>
        /// Date: 2017-11-11
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public static Boolean isValidProductName(string productName)
        {
            if (productName == null || productName.CompareTo(string.Empty) == 0 || productName.Length > 30)
            {
                Console.WriteLine("Invalid product name: " + productName);
                return false;
            }
            return true;
        }
        
        /// <summary>
        /// Product Global Count Validator
        /// 
        /// Validation Rule:
        ///     1. productGlobalCount must be must be a valid integer
        ///     
        /// <para> Author: Bill </para>
        /// Date: 2017-11-12
        /// </summary>
        /// <param name="productGlobalCount"></param>
        /// <returns></returns>
        public static Boolean isValidProductGlobalCount(int productGlobalCount)
        {
            if (productGlobalCount == int.MaxValue || productGlobalCount == int.MinValue)
            {
                Console.WriteLine("Invalid product global count: " + productGlobalCount);
                return false;
            }
            return true;
        }
    }
}
