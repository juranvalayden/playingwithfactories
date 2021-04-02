using Model.Interfaces;

namespace Model.Customers.Retail
{
    public class GoldCustomer : ICustomer
    {
        public decimal TotalBill()
        {
            return 12;
        }
    }
}