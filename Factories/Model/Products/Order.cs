using Model.Factories;
using Model.Interfaces;

namespace Model.Products
{
    public class Order
    {
        private ICustomer Customer;

        public Order()
        {
            Customer = SimpleFactory.CreateRetailCustomer("Gold");
            Customer.TotalBill();
        }
    }
}