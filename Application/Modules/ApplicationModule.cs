using Application.Contracts;
using Application.Contracts.Impl;
using Autofac;
using Persistence.Modules;

namespace Application.Modules
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .AsImplementedInterfaces()
                .InstancePerRequest();

            builder.RegisterModule(new PersistenceModule());

            builder.RegisterType<TodoItemManagementService>()
                .As<ITodoItemManagementService>()
                .InstancePerLifetimeScope();

        }
    }
}
