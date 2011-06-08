using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using IoCConcepts;
using NHibernate.Cfg;
using NHibernate.Driver;
using NHibernate.Dialect;
using System.Reflection;
using System.Text.RegularExpressions;

namespace IocConcepts.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Register(
                Component.For<ICustomerRepository>().ImplementedBy<CustomerRepository>(),
                Component.For<ICustomerValidator>().ImplementedBy<CustomerValidator>(),
                Component.For<ICreditCheck>().ImplementedBy<CreditCheck>()
                );

            var cfg = new Configuration();
            cfg.DataBaseIntegration(x => {
                x.ConnectionStringName="Default";
                x.Driver<SqlClientDriver>();
                x.Dialect<MsSqlCe40Dialect>();
                x.BatchSize = 50;
            });
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            var sessionfactory = cfg.BuildSessionFactory();
            using (var session = sessionfactory.OpenSession())
            {
                using (var trx = session.BeginTransaction())
                {
                    //blah
                    trx.Commit();
                }
            }

        }
    }
}
