using Model.Factories;
using Model.Interfaces;

namespace Model.Products
{
    public class Inventory
    {
        private ICustomer Customer;

        public Inventory()
        {
            Customer = SimpleFactory.CreateRetailCustomer("Gold");
            Customer.TotalBill();
        }
    }
}