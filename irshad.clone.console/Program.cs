﻿using irshad.clone.business.Concrete;
using irshad.clone.data.Concrete.EntityFramework;
using System;

namespace irshad.clone.console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pm = new ProductManager(new EfProductDal());

            //foreach (var item in pm.GetProductDetails())
            //{
            //    Console.WriteLine(item.ProductName + " "+ item.CatalogName);
            //}
        }
    }
}
