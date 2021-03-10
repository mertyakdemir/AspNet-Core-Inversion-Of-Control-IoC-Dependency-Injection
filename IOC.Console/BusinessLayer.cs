using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.Console
{
    internal class BusinessLayer
    {
        private IDAL _dal { get; set; }

        public BusinessLayer(IDAL dal)
        {
            _dal = dal;
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }

    }
}
