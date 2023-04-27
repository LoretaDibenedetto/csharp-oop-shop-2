// See https://aka.ms/new-console-template for more information
using shop2;



Console.WriteLine();

//Product newProduct1 = new Product("genere alimentare", "descrizione1", true, 3.0f, "salume ");
//Product newProduct2 = new Product("genere alimentare", "descrizione1", true, 3.0f, "salume ");

//Shop carrefour = new Shop("carrefour","catania","via andria", 45);
try { 
Water santanna = new Water( 1, 3, true, 0f , "acqua sant anna", "acqua molto buona", true,  1.4f ,"acqua naturale");
//Fruit banane = new Fruit("banane", "banane siciliane", true, 45.5f, "frutta", "africana");
Console.WriteLine(santanna.ToString());
}
catch(Exception ex) 
{
    Console.WriteLine(ex.Message);
}
//Console.WriteLine(carrefour.ToString());
//carrefour.AddProduct(newProduct1);
//Console.WriteLine(carrefour);

//Cart carrello1 = new Cart(3);
//Cart carrello2 = new Cart(3);


//carrello1.AddProduct(newProduct1);
//carrello1.AddProduct(newProduct2);
//carrello1.AddProduct(santanna);
//Console.WriteLine(carrello1.ToString());
//Console.WriteLine("i carrelli attualmente generati sono: "+ Cart.getTotalGenerateCart());

//Console.WriteLine("I prodotti attualmente generati sono: " + Product.GetTotalGeneratedProducts());
//water santAnna = new water(2,true,"acqua fresca", "descrizione fantasiosa", true, 45, 3);





//List<Product> productslistAgg2 = new List<Product> { newProduct1 };


//Console.WriteLine(newShop2.strRappresetation());