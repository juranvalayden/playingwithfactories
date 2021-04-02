using Model.Interfaces;

namespace Model.Products.Taxes
{
    public class LocalTax : ITax
    {
        public decimal Calculate()
        {
            return 7;
        }
    }
}