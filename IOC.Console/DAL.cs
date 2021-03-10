using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.Console
{
    internal class DAL : IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product{Id = 1, Name = "Test 1", Price=100},
                new Product{Id = 2, Name = "Test 2", Price=200},
                new Product{Id = 3, Name = "Test 3", Price=300},
                new Product{Id = 4, Name = "Test 4", Price=400},
                new Product{Id = 5, Name = "Test 5", Price=500},
            };
        }
    }
}
