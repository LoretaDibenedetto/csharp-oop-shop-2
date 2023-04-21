using shop2;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop2
{
    public class fruitBag:Product
    {
        //attributi
        private int fruitpieces;
       

        public fruitBag(int fruipieces, string nameProduct, string descriptionProduct, bool onSale, float price): base(nameProduct, descriptionProduct, onSale, price)
        { 
        
        this.fruitpieces = fruipieces;
        
        
        }

        public int Fruitpieces
        {
            get { return this.fruitpieces; }
            set { this.fruitpieces = value;  }
        }
        //metodi

        public void addBoxFruit(int quantity)
        {
            this.fruitpieces += quantity;
            if (this.fruitpieces > 230)
            {
                Console.WriteLine("ne hai aggiunti troppi lasciane un po' per tutti");
                
            }else if (this.fruitpieces < 0)
            {
                Console.WriteLine("aggiungi qualche box di frutta nel carrello prima di passare per la cassa!");
            }
        }

        public void addFruit(int quantity)
        {
            if (fruitpieces + quantity <= 5)
            {
                fruitpieces += quantity;
                Console.WriteLine("Hai aggiunto " + quantity + " pezzi di frutta a ");
            }
            else
            {
                Console.WriteLine("Il sacchetto di frutta è pieno. Non puoi aggiungere ulteriori pezzi di frutta.");
            }
        }
        public override string ToString()
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
