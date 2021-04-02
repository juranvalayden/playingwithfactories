using Model.Interfaces;

namespace Model.Products.Discounts
{
    public class NoDiscount : IDiscount
    {
        public decimal Calculate()
        {
            return 0;
        }
    }
}