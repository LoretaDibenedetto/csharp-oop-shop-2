using shop2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop2
{
    public class fruitBag:Product
    {
        //attributi
        private int fruitpieces;
       

        public fruitBag(int fruipieces, string nameProduct, string descriptionProduct, bool onSale, float price, float v) :base(nameProduct, descriptionProduct, onSale, price)
        { 
        
        this.fruitpieces = fruipieces;
        
        
        }

        public int Fruitpieces
        {
            get { return this.fruitpieces; }
            set { this.fruitpieces = value; if (this.fruitpieces > 5) { fruitpieces = 5; } }
        }
        //metodi
        public string strrappresentation()
        {   
            string strrappresentation = "Nome del prodotto:" + "  " + this.NameProduct + ", ";
            strrappresentation += "Descrizione:" + "  " + this.DescriptionProduct + ", ";
            strrappresentation += "pezzi di frutta" + "  " + this.fruitpieces+ ", ";
            
            strrappresentation += "Prezzo" + "  " + this.Price + ", ";
            strrappresentation += "E' in sconto?" + "  " + this.GetOnSale() + ". ";
            return strrappresentation;
        }

    }
}
