using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace HowToEditAndSavePivotCellValues
{
    public static class DatabaseHelper
    {
        #region Fields

        static readonly Random random = new Random();
        static readonly string[] FirstNames = { "Julia", "Stephanie", "Alex", "John", "Curtis", "Keith", "Timothy", "Jack", "Miranda", "Alice" };
        static readonly string[] LastNames = { "Black", "White", "Brown", "Smith", "Cooper", "Parker", "Walker", "Hunter", "Burton", "Douglas", "Fox", "Simpson" };
        static readonly string[] Adjectives = { "Ancient", "Modern", "Mysterious", "Elegant", "Red", "Green", "Blue", "Amazing", "Wonderful", "Astonishing", "Lovely", "Beautiful", "Inexpensive", "Famous", "Magnificent", "Fancy" };
        static readonly string[] ProductNames = { "Ice Cubes", "Bicycle", "Desk", "Hamburger", "Notebook", "Tea", "Cellphone", "Butter", "Frying Pan", "Napkin",
                    "Armchair", "Chocolate", "Yoghurt", "Statuette", "Keychain" };
        static readonly string[] CategoryNames = { "Business", "Presents", "Accessories", "Home", "Hobby" };

        static readonly string[] CustomerNames;
        static readonly string[] SalesPersonNames;
        static readonly ProductDataRecord[] Products;

        #endregion

        static DatabaseHelper()
        {
            CustomerNames = GenerateUniqueValues(random.Next(40, 50), GeneratePersonName).ToArray();
            SalesPersonNames = GenerateUniqueValues(random.Next(40, 50), GeneratePersonName).ToArray();
            Products = GenerateProducts();
        }

        #region Public
        public static Collection<MyOrderRow> CreateData()
        {
            Collection<MyOrderRow> orderList = new Collection<MyOrderRow>();
            for (int i = 0; i < 1500; i++)
            {
                MyOrderRow row = new MyOrderRow();
                row.ID = i;
                var product = DatabaseHelper.GetProduct();
                row.OrderDate = DatabaseHelper.GetOrderDate();
                row.Quantity = DatabaseHelper.GetQuantity();
                row.UnitPrice = DatabaseHelper.GetProductPrice(product);
                row.ExtendedPrice = row.Quantity * row.UnitPrice;
                row.CustomerName = DatabaseHelper.GetCustomerName();
                row.ProductName = product.ProductName;
                row.CategoryName = product.CategoryName;
                row.SalesPersonName = DatabaseHelper.GetSalesPersonName();
                row.NeedVerification = true;
                orderList.Add(row);
            }
            return orderList;
        }
        public static DateTime GetOrderDate()
        {
            return new DateTime(random.Next(2017, 2019), random.Next(1, 13), random.Next(1, 28));
        }
        public static int GetQuantity()
        {
            return random.Next(1, 100);
        }
        public static decimal GetProductPrice(ProductDataRecord product)
        {
            var price = product.UnitPrice * (decimal)(0.5 + random.NextDouble());
            return Math.Round(price, 2);
        }
        public static ProductDataRecord GetProduct()
        {
            return Products[random.Next(Products.Length)];
        }
        public static string GetCustomerName()
        {
            return CustomerNames[random.Next(CustomerNames.Length)];
        }
        public static string GetSalesPersonName()
        {
            return SalesPersonNames[random.Next(SalesPersonNames.Length)];
        }

        #endregion
        #region Private

        static List<T> GenerateUniqueValues<T>(int count, Func<T> generateValue)
        {
            var values = new HashSet<T>();
            while (values.Count < count)
            {
                var value = generateValue();
                if (!values.Contains(value))
                    values.Add(value);
            }
            return values.ToList();
        }

        static ProductDataRecord[] GenerateProducts()
        {
            return GenerateUniqueValues(random.Next(80, 100), GenerateProductName)
                .Select(productName => new ProductDataRecord
                {
                    ProductName = productName,
                    UnitPrice = random.Next(10, 500),
                    CategoryName = GenerateCategoryName()
                })
                .ToArray();
        }
        static string GenerateCategoryName()
        {
            return CategoryNames[random.Next(CategoryNames.Length)];
        }
        static string GeneratePersonName()
        {
            return FirstNames[random.Next(FirstNames.Length)] + " " + LastNames[random.Next(LastNames.Length)];
        }
        static string GenerateProductName()
        {
            return Adjectives[random.Next(Adjectives.Length)] + " " + ProductNames[random.Next(ProductNames.Length)];
        }
        #endregion
    }

    public class ProductDataRecord
    {
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

