using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop2
{
    public class FruitBag: Product
    {
        private int maxNumberFruits;
        private List<Fruit> fruitsInBag;

        public FruitBag(int maxNumberFruits , string nameProduct, string descriptionProduct, bool onSale, float price, string categoryName) : base(nameProduct, descriptionProduct, onSale, price, categoryName)
        {
        this.maxNumberFruits = maxNumberFruits;
        this.fruitsInBag = new List<Fruit>();
        
        
        
        }

        public int getMaxNumberFruits() 
        {  return maxNumberFruits; }

        public List<Fruit> GetFruitsInBag() 
        {  return fruitsInBag; }


        public void AddFruitInBag(Fruit newFruit)
        {
            if (this.fruitsInBag.Count < maxNumberFruits)
            {
                this.fruitsInBag.Add(newFruit);
            }
        }

        public void RemoveFruitInBag(Fruit fruitRemoved)
        {

            this.fruitsInBag.Remove(fruitRemoved);
        }
        public void AddListOfFruitInbag(List<Fruit> newFruitList)
        {
            foreach (Fruit newFruitListToAdd in newFruitList)
            {
                this.AddFruitInBag(newFruitListToAdd);
            }
        }


        public void ClearFruitsInBag()
        {  
             
            this.fruitsInBag.Clear(); 
        }
        public override string ToString()
        {
           string str = base.ToString();
            str += "type of bag; :" + this.maxNumberFruits + "\n";
            str += "fruit contained: " + "\n";
            foreach (Fruit fruitpiked in this.fruitsInBag)
            {
                 str += fruitpiked.ToString();
            }
            return str;
        }

        
    }
}
