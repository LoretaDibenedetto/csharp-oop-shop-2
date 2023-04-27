using shop2;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop2
{
    public class Fruit:Product
    {
        //attributi
        private string typeOfFruit;
        
       

        public Fruit( string nameProduct, string descriptionProduct, bool onSale, float price, string categoryName, string typeoffruit): base(nameProduct, descriptionProduct, onSale, price, categoryName)
        { 
        
        this.typeOfFruit = typeOfFruit;
        
        
        }

        public string GetTypeOfFruit
        {
            get { return this.typeOfFruit; }
        }


        //metodi


       
        public override string ToString()
        {
             string strrappresentation = "---------------------------------------------" + "\n";
             strrappresentation += "Nome del prodotto:" + "  " + this.NameProduct + "\n ";
            strrappresentation += "Descrizione:" + "  " + this.DescriptionProduct + "\n ";
            strrappresentation += "tipo di frutta" + "  " + this.typeOfFruit + "\n ";
            
            strrappresentation += "Prezzo" + "  " + this.Price + "\n ";
            strrappresentation += "E' in sconto?" + "  " + this.GetOnSale() + "\n ";
            strrappresentation += "categoria :" + "  " + this.category+ "\n ";
            return strrappresentation;
        }
        
        

    }
}
