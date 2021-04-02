using Model.Interfaces;

namespace Model.Products.Taxes
{
    public class NoTax : ITax
    {
        public decimal Calculate()
        {
            return 0;
        }
    }
}