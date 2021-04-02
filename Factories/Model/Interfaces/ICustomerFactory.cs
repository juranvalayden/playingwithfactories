namespace Model.Interfaces
{
    // Define an interface for creating an object and let the subclasses decide which classes to instantiate
    public interface ICustomerFactory
    {
        ITax CreateTax();
        IDiscount CreateDiscount();
        IDelivery CreateDelivery();
        ICustomer CreateCustomer();
    }
}