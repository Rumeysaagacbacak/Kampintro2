using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //snippet -hazır kodlar .
        public int Id { get; set; }
        public int CategoryId { get; set; } //kategori ıd
        public string ProductName { get; set; }//üürn ismi
        public double UnitPrice { get; set; } //ürünün birim fiyatı
        public int UnitInStok  { get; set; } //ürün stok adedi

        
    }
}
