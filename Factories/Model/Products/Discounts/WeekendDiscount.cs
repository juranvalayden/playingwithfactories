using Model.Interfaces;

namespace Model.Products.Discounts
{
    public class WeekendDiscount : IDiscount
    {
        public decimal Calculate()
        {
            return 5;
        }
    }
}