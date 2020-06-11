using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.Lib
{
    public static class IoCLoader
    {
        public static WindsorContainer container { get; private set; }

        static IoCLoader()
        {
            container = new WindsorContainer();
            switch (AppGlobalSettings.CompanyFactory)
            {
                case ("test"):
                    container.Register(Component
                        .For<ICompanyListLoader>()
                        .ImplementedBy<CompanyTestListLoader>()
                        .LifeStyle.Singleton);
                    break;
                case ("split"):
                    container.Register(Component
                        .For<ICompanyListLoader>()
                        .ImplementedBy<CompanyListSplitFileLoader>()
                        .LifeStyle.Singleton);
                    break;
                case ("json"):
                    container.Register(Component
                        .For<ICompanyListLoader>()
                        .ImplementedBy<CompanyListJsonLoader>()
                        .LifeStyle.Singleton);
                    break;
                default:
                    container.Register(Component
                        .For<ICompanyListLoader>()
                        .ImplementedBy<CompanyTestListLoader>()
                        .LifeStyle.Singleton);
                    break;
            }
        }
    }
}
