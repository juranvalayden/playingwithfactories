using Model.Interfaces;

namespace Model.Customers.Corporate
{
    public class PublicCorporation : ICorporationType
    {
        public decimal CalculateCredit()
        {
            return 25;
        }
    }
}