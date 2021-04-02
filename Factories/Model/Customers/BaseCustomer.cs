using Model.Interfaces;

namespace Model.Customers
{
    public class BaseCustomer : ICustomer
    {
        private readonly ITax _tax;
        private readonly IDiscount _discount;
        private readonly IDelivery _delivery;
        public decimal TotalPurchase { get; set; }

        public BaseCustomer(ITax tax, IDiscount discount, IDelivery delivery)
        {
            _tax = tax;
            _discount = discount;
            _delivery = delivery;
        }

        public virtual decimal TotalBill()
        {
            return TotalPurchase + _tax.Calculate() -_discount.Calculate() + _delivery.Calculate();
        }
    }
}
