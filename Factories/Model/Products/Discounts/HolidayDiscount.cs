using Model.Interfaces;

namespace Model.Products.Discounts
{
    public class HolidayDiscount : IDiscount
    {
        public decimal Calculate()
        {
            return 7;
        }
    }
}