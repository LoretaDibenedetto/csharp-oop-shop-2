using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop2
{
    public class Cart
    {
        private static int numberOfGeneratedCart = 0;
        private List<Product> productsInCart;
        private int maxProductsInCart;

        // COSTRUTTORE
        public Cart(int maxProductsInCart)
        {
            this.maxProductsInCart = maxProductsInCart;
            this.productsInCart = new List<Product>();
            numberOfGeneratedCart++;
        }

        // GETTERS
        public List<Product> GetProductListInsideCart()
        {
            return this.productsInCart;
        }
        public static int getTotalGenerateCart()
        {
            return numberOfGeneratedCart;
        }
        public int GetNUmbersOfProductsInCart()
        {
            return productsInCart.Count;
        }
        // SETTERS

        // METHODS

        public void AddProduct(Product newProduct)
        {
            if(productsInCart.Count < maxProductsInCart)
            {
                this.productsInCart.Add(newProduct);
            }
            else
            {
                throw new Exception("il carrello e' pieno");
            }
        }

        public void EmptyCart()
        {   if(productsInCart.Count == 0)
            {
                throw new Exception("non puoi svuotare il carrello perche' e' gia' vuoto" );
            }
            else
            {
               this.productsInCart.Clear();

            }
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

