using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;





namespace shop2
{
    public class Product

    {

        private static int numberOfGeneratedProduct = 0;


        private string nameProduct;
        private string descriptionProduct;
        private int barCode;
        private bool onSale;
        private float price;
        private protected Category category;

        //Costruttore
        public Product(string nameProduct, string descriptionProduct, bool onSale, float price, string categoryName ) 
        {

            this.nameProduct = nameProduct;
            this.descriptionProduct = descriptionProduct;
            this.barCode = GenerateCode();
            this.onSale = onSale;
            this.price = price;
            this.category = new Category(categoryName);

            numberOfGeneratedProduct++;
        }

      

        //Getters setters

        //nome prodotto
        public string NameProduct
        {
            get { return this.nameProduct; }
            set { this.nameProduct = value; }
        }

        //descrizione
        public string DescriptionProduct
        {
            get { return this.descriptionProduct; }
            set { this.descriptionProduct = value; }
        }
        //codice a barre
        public int BarCode
        {
            get { return this.barCode; }
        }
        //prezzo prodotto
        public float Price
        {
            get { return (float)this.price; }
            set { this.price = (float)value; }
        }

       

        //saldo prodotto 
        //getters
        public bool GetOnSale()
        {
            return this.onSale;
        }
        public static int GetTotalGeneratedProducts()
        {
            return numberOfGeneratedProduct;
        }
        //setters
        public bool SetOnSale()
        {
            return onSale = false;
        }


        //metodi

        //generare numero randomico
        public int GenerateCode()
        {
            Random rnd = new Random();
            return rnd.Next(10000000, 99999999);

        }



        public override string ToString()   
        {
            string rapprString = "Nome del prodotto : " + this.nameProduct + ", ";
            rapprString += "Description : " + this.descriptionProduct + ", ";
            rapprString += "Prezzo: " + this.price + ", ";
            rapprString += "Barcode: " + this.barCode + ", ";
            rapprString += "Is on sale? " + this.onSale + ", ";
            rapprString += "category: " + this.category.ToString();
           return rapprString;
        }


    }
}