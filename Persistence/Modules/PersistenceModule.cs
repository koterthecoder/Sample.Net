using Autofac;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Modules
{
    public class PersistenceModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            try
            {
                var contextRegistration = builder.RegisterType<DomainContext>().As<DomainContext>();
                contextRegistration.InstancePerLifetimeScope();

                builder.RegisterType<TodoItemRepository>().As<IRepository<TodoItemRepository>>();
                builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
