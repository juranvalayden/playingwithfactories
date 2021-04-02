namespace Model.Interfaces
{
    public interface ICorporateCustomerFactory : ICustomerFactory
    {
        ICorporationType CreateCorporateType();
    }
}