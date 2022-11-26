
vagetable product1 = new vagetable();
product1.Urunid = "Tomato";
product1.Urunfiyat = 24;
product1.Urunstok = 5000;

vagetable product2 = new vagetable();
product2.Urunid = "Cucumber";
product2.Urunfiyat = 20;
product2.Urunstok = 4600;

vagetable product3 = new vagetable();
product3.Urunid = "Apple";
product3.Urunfiyat = 21;
product3.Urunstok = 100;

vagetable product4 = new vagetable();
product4.Urunid = "Banana";
product4.Urunfiyat = 6;
product4.Urunstok = 3000;

vagetable product5 = new vagetable();
product5.Urunid = "Lemon";
product5.Urunfiyat = 41;
product5.Urunstok = 9000;

vagetable[] product = new vagetable[] {product1, product2, product3, product4, product5};

foreach (vagetable productitem in product)
{
    Console.WriteLine("Ürün İsimi :" + productitem.Urunid);   
    Console.WriteLine("Ürün Fiyetı :" + productitem.Urunfiyat);
    Console.WriteLine("Stok Bilgisi :" + productitem.Urunstok);
    Console.WriteLine();
    Console.WriteLine("Diğer Ürün");
    Console.WriteLine();
}
Console.ReadLine();

class vagetable
{
    public string Urunid { get; set; }

    public int Urunfiyat { get; set; }

    public int Urunstok { get; set; }
}


 


    
