using Autofac;
using DependencyInjectionLibrary;
using DependencyInjectionLibrary.Utilities;
using DependencyInjectionUI.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Before Dependency Injection
            //DataAccess ve Logger instance'larını getirmek için Factory kullanılabilir, bu IoC'ye örnektir.
            //Instance'lar aşağıdaki şekilde verilebilir, bu Dependency Inversion kullanımıdır.
            //BusinessLogic businessLogic = new BusinessLogic(new DataAccess(), new Logger());
            //businessLogic.ProcessData();

            //Dependency Injection ile object instance'larını burada yukarıdaki gibi vermekten kurtarılarak, daha loosely coupled bir yapı oluşturulur.

            //After Dependency Injection
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
            Console.ReadLine();
        }
    }
}
