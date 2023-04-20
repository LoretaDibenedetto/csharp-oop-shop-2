// See https://aka.ms/new-console-template for more information
using shop2;


shop newShop2 = new shop("negozio altamente bello2", "Roma", "via dei pini", 34);

Product newProduct1 = new Product("genere alimentare", "descrizione1", true, 3.0f);
newShop2.AddProduct(newProduct1);

water santAnna = new water(2,true,"acqua fresca", "descrizione fantasiosa", true, 45, 3);
fruitBag fruittella = new fruitBag(6, "fruittella", "bella bella", true, 200, 1);
Console.WriteLine(santAnna.strrappresentation());

Console.WriteLine(fruittella.strrappresentation());

//List<Product> productslistAgg2 = new List<Product> { newProduct1 };


Console.WriteLine(newShop2.strRappresetation());