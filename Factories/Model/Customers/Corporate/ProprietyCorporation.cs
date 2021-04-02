using Model.Interfaces;

namespace Model.Customers.Corporate
{
    public class ProprietyCorporation : ICorporationType
    {
        public decimal CalculateCredit()
        {
            return 18;
        }
    }
}