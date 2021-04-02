using Model.Interfaces;

namespace Model.Customers.Retail
{
    public class BronzeCustomer : ICustomer // SpecialCustomer
    {
        public decimal TotalBill()
        {
            return 1;
        }

        public ICustomer Clone()
        {
            return (ICustomer) MemberwiseClone();
        }
    }
}