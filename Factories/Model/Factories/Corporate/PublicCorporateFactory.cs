using Model.Customers.Corporate;
using Model.Interfaces;

namespace Model.Factories.Corporate
{
    public class PublicCorporateFactory : BaseCorporateFactory
    {
        public override ICorporationType CreateCorporateType()
        {
            return new PublicCorporation();
        }
    }
}