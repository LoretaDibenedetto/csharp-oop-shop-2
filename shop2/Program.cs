// See https://aka.ms/new-console-template for more information
using shop2;



Console.WriteLine();

Product newProduct1 = new Product("genere alimentare", "descrizione1", true, 3.0f);

water santanna = new water( 23,34, true, "acqua sant anna", "acqua molto buona", true,  23f);
fruitBag fruittella = new fruitBag(6, "fruittella", "bella bella", true, 200);

santanna.addToCart(23);
fruittella.addFruit(3);
Console.WriteLine(santanna.GetProductString()); 
Console.WriteLine(newProduct1.GetProductString());

Console.WriteLine(fruittella.GetProductString());


//water santAnna = new water(2,true,"acqua fresca", "descrizione fantasiosa", true, 45, 3);
 
//Console.WriteLine(santAnna.strrappresentation());

//Console.WriteLine(fruittella.strrappresentation());

//List<Product> productslistAgg2 = new List<Product> { newProduct1 };


//Console.WriteLine(newShop2.strRappresetation());