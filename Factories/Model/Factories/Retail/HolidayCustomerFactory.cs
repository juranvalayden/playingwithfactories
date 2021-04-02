using Model.Interfaces;
using Model.Products.Discounts;

namespace Model.Factories.Retail
{
    public class HolidayCustomerFactory : BaseCustomerFactory
    {
        public override IDiscount CreateDiscount()
        {
            return new HolidayDiscount();
        }
    }
}