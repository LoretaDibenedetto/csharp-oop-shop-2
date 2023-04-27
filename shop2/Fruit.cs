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

        public string TypeOfFruit
        {
            get { return this.typeOfFruit; }
        }


        //metodi


       
        public override string ToString()
        {
             
            string strrappresentation = "Nome del prodotto:" + "  " + this.NameProduct + ", ";
            strrappresentation += "Descrizione:" + "  " + this.DescriptionProduct + ", ";
            strrappresentation += "tipo di frutta" + "  " + this.typeOfFruit + ", ";
            
            strrappresentation += "Prezzo" + "  " + this.Price + ", ";
            strrappresentation += "E' in sconto?" + "  " + this.GetOnSale() + ", ";
            strrappresentation += "categoria :" + "  " + this.category+ ". ";
            return strrappresentation;
        }
        
        

    }
}
