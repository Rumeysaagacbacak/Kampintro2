﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStok = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5,UnitInStok=5,ProductName="Kalem",UnitPrice=35 };



            //int ,double,bool .... Değer tip
            //diziler ,class,abstract cclass,interface ...Referans tip 
            //ref out 

            //PascalCase ---İlk harf büyük ,,//camelCase--ilk küçük sonra büyük
            //case sensitive --küçük büyük harf duyarlı
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


           


        }
    }
}
