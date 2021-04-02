// ######################################################################
// The factory method let's a class defer instantiation to its subclasses
// -- Local tax, no discount and courier charge
// -- This is the factory method!
// -- This becomes the base customer factory with the most common combination
// ######################################################################

using Model.Customers;
using Model.Interfaces;
using Model.Products.Deliveries;
using Model.Products.Discounts;
using Model.Products.Taxes;

namespace Model.Factories
{
    public class BaseCustomerFactory : ICustomerFactory
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
            return new BaseCustomer(CreateTax(), CreateDiscount(), CreateDelivery());
        }
    }
}