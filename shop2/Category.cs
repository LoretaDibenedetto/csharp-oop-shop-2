namespace shop2
{
    public class Category
    {
        private string name;


        public Category()
        {
            this.name = name;
        }
        public Category(string name)
        {
            this.name = name;
        }
        public string GetName(string name)
        {
            return name;
        }


        public override string ToString()
        {
            return this.name;
        }
    }
}