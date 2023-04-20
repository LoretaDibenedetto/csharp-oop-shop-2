using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    public class shop
    {
        //ATTRIBUTI
        private string shopName;
        private string shopCity;

        private string shopAddress;
        private int shopCivicNUmber;
        private List<Product> ProductList;


        //COSTRUTTORE
        public shop(string shopName, string shopCity, string shopAddress, int shopCivicNUmber)
        {

            this.shopName = shopName;
            this.shopCity = shopCity;
            this.shopAddress = shopAddress;
            this.ProductList = new List<Product>();
            this.shopCivicNUmber = shopCivicNUmber;

        }

        //GETTERS setters
        public  string ShopName
        { get { return this.shopName; } }

        public string ShopCity
        { get { return this.shopCity; } set { this.shopCity = value; } }

        public string ShopAddress
        { get { return this.shopAddress; } set { this.shopAddress = value; } }

        public int ShopCivicNUmber
        {
            get { return this.shopCivicNUmber; }
            set { this.shopCivicNUmber = value; }
        }

        public List<Product> GetProducts()
        {

            return this.ProductList;


        }

        //metodi

        public void AddProduct(Product newProduct)
        {
            ProductList.Add(newProduct);
        }

        public void RemoveProduct(Product removeProduct)
        {

            ProductList.Remove(removeProduct);
        }


        public void addProductList(List<Product> listAddProduct)
        {


            foreach (Product productAddnew in listAddProduct)
            {
                this.ProductList.Add(productAddnew);
            }

        }

        public string strRappresetation()
        {
            string rapprString = "shop name: " + this.shopName + "\n";
            rapprString += "shop city: " + this.shopCity + "\n";
            rapprString += "shop address: " + this.shopAddress + "\n";
            rapprString += "product: \n";

            foreach (Product productScan in ProductList)
            {
                rapprString += " - " + productScan.GetProductString() + "\n";
            }

            rapprString += "\n";

            return rapprString;
        }




    }
}
