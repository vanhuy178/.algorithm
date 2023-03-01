namespace SanPham
{
    public partial class Product
    {
        public MenuFactory menuFactory { get; set; }
        public class MenuFactory
        {
            public string NameFactory { get; set; }
            public string Address { get; set; }

            public string GetInfoMenuFactory()
            {
                return $"Name of the factory: {NameFactory}, address: {Address}";
            }
        }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public string GetInfo()
        {
            return $"Name of product is: {Name}, price: {Price}, desc: {Description}";
        }
    }
}