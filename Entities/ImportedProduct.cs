using System.Globalization;

namespace Course4.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsFree)
            : base(name, price)
        {
            CustomsFree = customsFree;
        }

        public double totalPrice()
        {
            return Price += CustomsFree;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                + totalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs Free: $ "
                + CustomsFree.ToString("F2", CultureInfo.InvariantCulture) 
                + ") ";   
        }
    }
}
