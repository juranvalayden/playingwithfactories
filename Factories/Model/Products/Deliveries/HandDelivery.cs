using Model.Interfaces;

namespace Model.Products.Deliveries
{
    public class HandDelivery : IDelivery
    {
        public decimal Calculate()
        {
            return 5;
        }
    }
}