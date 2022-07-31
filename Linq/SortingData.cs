using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Comparers;
using Linq.DataSources;

namespace Linq
{
    /// <summary>
    /// Considers the use sorting operations (methods 'OrderBy','OrderByDescending', 'ThenBy', 'ThenByDescending', and 'Reverse'
    /// and 'orderby', 'descending' keywords) in LINQ queries.
    /// Sorting operation definition:
    /// <see cref="IEnumerable{TSource}"/> → <see cref="IOrderedEnumerable{TSource}"/>.
    /// A sorting operation orders the elements of a sequence based on one or more attributes.
    /// </summary>
    public static class SortingData
    {
        /// <summary>
        /// Sorts a list of words alphabetically.
        /// </summary>
        /// <returns>Sorted alphabetically sequence of words.</returns>
        public static IEnumerable<string> OrderBy()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            return words.OrderBy(x => x[0]);
        }

        /// <summary>
        ///  Sorts a list of words by length.
        /// </summary>
        /// <returns>Sorted by length sequence of words.</returns>
        public static IEnumerable<string> OrderByProperty()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            return words.OrderBy(x => x.Length);
        }

        /// <summary>
        /// Sorts a list of products by name.
        /// </summary>
        /// <returns>Sorted sequence of products by name.</returns>
        public static IEnumerable<Product> OrderByProducts()
        {
            List<Product> products = Products.ProductList;

            return products.OrderBy(x => x.ProductName);
        }

        /// <summary>
        /// Sorts a list of words alphabetically case insensitive.
        /// </summary>
        /// <returns>Sorted alphabetically sequence of words.</returns>
        public static IEnumerable<string> OrderByWithCustomComparer()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            return words.OrderBy(x => x.ToLower(System.Globalization.CultureInfo.CurrentCulture));
        }

        /// <summary>
        /// Sorts a list of doubles from highest to lowest.
        /// </summary>
        /// <returns>Sorted sequence of doubles.</returns>
        public static IEnumerable<double> OrderByDescending()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            return doubles.OrderByDescending(x => x);
        }

        /// <summary>
        /// Sorts a list of products by units in stock from highest to lowest.
        /// </summary>
        /// <returns>Sorted by units in stock sequence of products.</returns>
        public static IEnumerable<Product> OrderProductsDescending()
        {
            List<Product> products = Products.ProductList;

            return products.OrderByDescending(x => x.UnitsInStock);
        }

        /// <summary>
        /// Sorts descending a list of words alphabetically case insensitive.
        /// </summary>
        /// <returns>Sorted descending sequence of words alphabetically case insensitive.</returns>
        public static IEnumerable<string> DescendingCustomComparer()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            return words.OrderByDescending(x => x.ToLower(System.Globalization.CultureInfo.CurrentCulture));
        }

        /// <summary>
        /// Sorts a list of digits, first by length of their name, and then alphabetically by the name itself.
        /// </summary>
        /// <returns>Sorted sequence of digits.</returns>
        public static IEnumerable<string> ThenBy()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            return digits.OrderBy(x => x.Length).ThenBy(x => x);
        }

        /// <summary>
        /// Sorts a list of words, first by length of their name, and then alphabetically case insensitive by the name itself.
        /// </summary>
        /// <returns>Sorted sequence of words.</returns>
        public static IEnumerable<string> ThenByCustom()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            return words.OrderBy(x => x.Length).ThenBy(x => x);
        }

        /// <summary>
        /// Sorts a list of products, first by category, and then by unit price, from highest to lowest.
        /// </summary>
        /// <returns>Sorted sequence of products.</returns>
        public static IEnumerable<Product> ThenByDifferentOrdering()
        {
            List<Product> products = Products.ProductList;

            return products.OrderBy(x => x.Category).ThenByDescending(x => x.UnitPrice);
        }

        /// <summary>
        /// Sorts a list of words, first by length of their name, and then descending alphabetically case insensitive by the name itself.
        /// </summary>
        /// <returns>Sorted sequence of words.</returns>
        public static IEnumerable<string> CustomThenByDescending()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            return words.OrderBy(x => x.Length).ThenByDescending(x => x.ToLower(System.Globalization.CultureInfo.CurrentCulture));
        }

        /// <summary>
        /// Gets a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
        /// </summary>
        /// <returns>Reverse sequence of digits whose second letter is 'i'.</returns>
        public static IEnumerable<string> OrderingReversal()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            return digits.Where(x => x[1] == 'i').Reverse();
        }
    }
}
