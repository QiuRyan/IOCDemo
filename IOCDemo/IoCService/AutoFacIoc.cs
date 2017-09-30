using System;
using Autofac;
using IOC.Demo.Lib;

namespace IOCDemo
{
    public class AutoFacIoc : IIocType
    {
        private readonly ContainerBuilder builder;
        private readonly IContainer container;

        public AutoFacIoc()
        {
            this.builder = new ContainerBuilder();
            this.builder.RegisterType<UserService>().As<IUser>();
            this.builder.RegisterType<SchoolService>().As<ISchool>();
            this.container = this.builder.Build();
        }

        public void GetCurrentIocType()
        {
            using (ILifetimeScope scope = this.container.BeginLifetimeScope())
            {
                ISchool schoolService = scope.Resolve<ISchool>();
                Console.WriteLine("Autofac : " + schoolService.GetUser());
            }
        }
    }
}