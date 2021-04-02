using Model.Factories;
using Model.Interfaces;

namespace Model.Products
{
    public class Invoice
    {
        private ICustomer Customer;

        public Invoice()
        {
            Customer = SimpleFactory.CreateRetailCustomer("Gold");
            Customer.TotalBill();
        }
    }
}