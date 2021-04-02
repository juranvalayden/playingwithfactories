using Model.Customers.Corporate;
using Model.Interfaces;
using Model.Products.Deliveries;
using Model.Products.Discounts;
using Model.Products.Taxes;

namespace Model.Factories.Corporate
{
    public class BaseCorporateFactory : ICorporateCustomerFactory
    {
        public virtual ITax CreateTax()
        {
            return new LocalTax();
        }

        public virtual IDiscount CreateDiscount()
        {
            return new NoDiscount();
        }

        public virtual IDelivery CreateDelivery()
        {
            return new CourierDelivery();
        }

        public ICustomer CreateCustomer()
        {
            // NB :- Very important step!
            return new BaseCorporateCustomer(CreateTax(), CreateDiscount(), CreateDelivery(), CreateCorporateType());
        }

        public virtual ICorporationType CreateCorporateType()
        {
            return new ProprietyCorporation();
        }
    }
}