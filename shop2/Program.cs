// See https://aka.ms/new-console-template for more information
using shop2;



Console.WriteLine("=========================================================================");

Product newProduct1 = new Product("genere alimentare", "descrizione1", true, 3.0f, "salume ");
Product newProduct2 = new Product("genere alimentare", "descrizione1", true, 3.0f, "salume ");

try { 
Water santanna = new Water( 2.5f , 1.5f, 1 , true, 1.4f , "acqua sant anna", "acqua molto buona da una fonte di montagna di quelle alte", true,  1.4f ,"acqua naturale");
   //santanna.drink(1f);
     santanna.Fill(20.4f);
   
    Console.WriteLine("la conversione in galloni e': " + santanna.ConvertInGallons(34.4));

    Console.WriteLine(santanna);
}
catch(Exception ex) 
{
    Console.WriteLine(ex.Message);
}

Shop carrefour = new Shop("carrefour","catania","via andria", 45);




Fruit banane = new Fruit("banane", "banane siciliane", true, 45.5f, "frutta", "africana");
Fruit banana = new Fruit("banane", "banane siciliane", true, 45.5f, "frutta", "africana");
    Fruit banano = new Fruit("banane", "banane siciliane", true, 45.5f, "frutta", "africana");

    FruitBag bustadifrutta = new FruitBag(3, "busta di frutta mista", "una busta di frutta mista: banane, pere, mele", true, 3.5f, "frutta");
    bustadifrutta.AddFruitInBag(banane);
    bustadifrutta.AddFruitInBag(banana);
    bustadifrutta.AddFruitInBag(banano);

    bustadifrutta.AddListOfFruitInbag(new List<Fruit> { banana, banane,banano });


    Console.WriteLine(bustadifrutta);



//Console.WriteLine(carrefour);
//carrefour.AddProduct(newProduct1);
//Console.WriteLine(carrefour);

//Cart carrello1 = new Cart(3);
//Cart carrello2 = new Cart(3);


//carrello1.AddProduct(newProduct1);
//carrello1.AddProduct(newProduct2);
//carrello1.AddProduct(santanna);
//Console.WriteLine(carrello1);
//Console.WriteLine("i carrelli attualmente generati sono: "+ Cart.getTotalGenerateCart());

//Console.WriteLine("I prodotti attualmente generati sono: " + Product.GetTotalGeneratedProducts());
//water santAnna = new water(2,true,"acqua fresca", "descrizione fantasiosa", true, 45, 3);





//List<Product> productslistAgg2 = new List<Product> { newProduct1 };


