// See https://aka.ms/new-console-template for more information
using shop2;



Console.WriteLine();

Product newProduct1 = new Product("genere alimentare", "descrizione1", true, 3.0f, "salume ");

Water santanna = new Water( 1, 3, true, 1.3f , "acqua sant anna", "acqua molto buona", true,  2.3f ,"acqua naturale");
Fruit fruittella = new Fruit("banane", "banane siciliane", true, 45.5f, "frutta", "africana");

Console.WriteLine(santanna.ToString()); 
Console.WriteLine(newProduct1.ToString());

Console.WriteLine(fruittella.ToString());


//water santAnna = new water(2,true,"acqua fresca", "descrizione fantasiosa", true, 45, 3);
 
//Console.WriteLine(santAnna.strrappresentation());

//Console.WriteLine(fruittella.strrappresentation());

//List<Product> productslistAgg2 = new List<Product> { newProduct1 };


//Console.WriteLine(newShop2.strRappresetation());