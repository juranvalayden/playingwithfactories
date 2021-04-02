using Model.Interfaces;

namespace Model.Customers.Retail
{
    public class SilverCustomer : ICustomer
    {
        public decimal TotalBill()
        {
            return 5;
        }
    }
}