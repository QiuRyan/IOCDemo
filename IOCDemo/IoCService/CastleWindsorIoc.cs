using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using IOC.Demo.Lib;

namespace IOCDemo
{
    public class CastleWindsorIoc : IIocType
    {
        private readonly IWindsorContainer container;

        public CastleWindsorIoc()
        {
            this.container = new WindsorContainer();
            this.container.Register(Component.For<IUser>().ImplementedBy<UserService>());
            this.container.Register(Component.For<ISchool>().ImplementedBy<SchoolService>());
        }

        public void GetCurrentIocType()
        {
            ISchool schoolService = this.container.Resolve<ISchool>();

            Console.WriteLine("CastleWindsor : " + schoolService.GetUser());
        }
    }
}