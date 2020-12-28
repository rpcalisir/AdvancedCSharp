using Autofac;
using DependencyInjectionLibrary;
using DependencyInjectionLibrary.Utilities;
using System.Linq;
using System.Reflection;

namespace DependencyInjectionUI.Helper
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            builder.RegisterType<Application>().As<IApplication>();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DependencyInjectionLibrary))).
                Where(t => t.Namespace.Contains("Utilities")).
                As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
