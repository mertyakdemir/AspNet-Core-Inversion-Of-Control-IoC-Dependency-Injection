using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.Console
{
    internal class OracleDAL : IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product{Id = 1, Name = "Oracle 1", Price=100},
                new Product{Id = 2, Name = "Oracle 2", Price=200},
                new Product{Id = 3, Name = "Oracle 3", Price=300},
                new Product{Id = 4, Name = "Oracle 4", Price=400},
                new Product{Id = 5, Name = "Oracle 5", Price=500},
            };
        }
    }
}
