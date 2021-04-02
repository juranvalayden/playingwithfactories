using Model.Interfaces;

namespace Model.Products.Deliveries
{
    public class CourierDelivery : IDelivery
    {
        public decimal Calculate()
        {
            return 5;
        }
    }
}