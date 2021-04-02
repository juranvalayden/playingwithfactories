using Model.Factories.Corporate;
using Model.Factories.Retail;
using Model.Interfaces;
using Unity;

namespace Model.Factories
{
    public static class SimpleFactory 
    {
        // centralizes the new keyword
        // Creating FAMILIES of factories
        private static readonly UnityContainer RetailCustomerFactory = new UnityContainer();
        private static readonly UnityContainer CorporateCustomerFactory = new UnityContainer();

        static SimpleFactory()
        {
            RetailCustomerFactory.RegisterType<ICustomerFactory, BaseCustomerFactory>("Normal");
            RetailCustomerFactory.RegisterType<ICustomerFactory, NoTaxCustomerFactory>("No Tax");
            RetailCustomerFactory.RegisterType<ICustomerFactory, HolidayCustomerFactory>("Holiday");
            RetailCustomerFactory.RegisterType<ICustomerFactory>();

            CorporateCustomerFactory.RegisterType<ICorporateCustomerFactory, BaseCorporateFactory>("Propriety");
            CorporateCustomerFactory.RegisterType<ICorporateCustomerFactory, PublicCorporateFactory>("Public");
            CorporateCustomerFactory.RegisterType<ICorporateCustomerFactory>();
        }

        public static ICustomer CreateRetailCustomer(string customerType)
        {
            return RetailCustomerFactory.Resolve<ICustomerFactory>(customerType).CreateCustomer();
        }

        public static ICustomer CreateCorporateCustomer(string customerType)
        {
            return CorporateCustomerFactory.Resolve<ICorporateCustomerFactory>(customerType).CreateCustomer();
        }
    }
}