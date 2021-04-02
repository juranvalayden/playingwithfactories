using Model.Interfaces;

namespace Model.Products.Discounts
{
    public class WorkWeekDiscount : IDiscount
    {
        public decimal Calculate()
        {
            return 2;
        }
    }
}