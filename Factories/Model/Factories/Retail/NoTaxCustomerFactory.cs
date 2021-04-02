using Model.Interfaces;
using Model.Products.Taxes;

namespace Model.Factories.Retail
{
    public class NoTaxCustomerFactory : BaseCustomerFactory
    {
        // no tax, no discount and courier charge | NB | we are just using the BaseCustomerFactory and overriding local tax to no tax :)
        // This is the factory method!
        public override ITax CreateTax()
        {
            return new NoTax();
        }
    }
}