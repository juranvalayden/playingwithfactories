using Model.Interfaces;

namespace Model.Customers.Corporate
{
    public class BaseCorporateCustomer : BaseCustomer
    {
        private readonly ICorporationType _corporationType;
        public BaseCorporateCustomer(ITax tax, IDiscount discount, IDelivery delivery, ICorporationType corporationType) : base(tax, discount, delivery)
        {
            _corporationType = corporationType;
        }

        public override decimal TotalBill()
        {
            return base.TotalBill() - _corporationType.CalculateCredit();
        }
    }
}