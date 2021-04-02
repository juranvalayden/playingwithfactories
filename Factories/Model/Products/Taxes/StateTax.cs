using Model.Interfaces;

namespace Model.Products.Taxes
{
    public class StateTax : ITax
    {
        public decimal Calculate()
        {
            return 15;
        }
    }
}