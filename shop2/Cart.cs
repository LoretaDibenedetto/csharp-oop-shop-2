using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop2
{
    public class Cart
    {
        private List<Product> productsInCart;
        private int maxProductsInCart;

        // COSTRUTTORE
        public Cart(int maxProductsInCart)
        {
            this.maxProductsInCart = maxProductsInCart;
            this.productsInCart = new List<Product>();
        }

        // GETTERS
        public List<Product> GetProductListInsideCart()
        {
            return this.productsInCart;
        }

        // SETTERS

        // METHODS
        public int GetNUmbersOfProductsInCart()
        {
            return productsInCart.Count;
        }

        public void AddProduct(Product newProduct)
        {
            if (productsInCart.Count < maxProductsInCart)
            {
                this.productsInCart.Add(newProduct);
            }
            else
            {
                throw new Exception("il carrello e' pieno");
            }
        }

        public void EmptyCart()
        {
            this.productsInCart.Clear();
        }

        public override string ToString()
        {
            string stringa = "--------- CARRELLO DELLA SPESA ---------\n";
            for (int i = 0; i < this.productsInCart.Count; i++)
            {
                stringa += $"PRODOTTO {i + 1}:\n";
                Product prodottoEstratto = productsInCart[i];

                if (prodottoEstratto is Fruit)
                {
                    Fruit fruttoEstratto = (Fruit)prodottoEstratto;
                    stringa += fruttoEstratto.ToString();
                }
                else
                {
                    stringa += prodottoEstratto.ToString();
                }

                stringa += "\n";
            }
            stringa += "---------------------------------";

            return stringa;
        }
    }
}

