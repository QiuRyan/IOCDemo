using System;
using IOC.Demo.Lib;
using Ninject;

namespace IOCDemo
{
    public class NinjectIoc : IIocType
    {
        private readonly IKernel kernel = new StandardKernel();

        public NinjectIoc()
        {
            this.kernel.Bind<IUser>().To<UserService>().InSingletonScope();
            this.kernel.Bind<ISchool>().To<SchoolService>().InSingletonScope();
        }

        public void GetCurrentIocType()
        {
            ISchool schoolService = this.kernel.Get<ISchool>();

            Console.WriteLine("Ninject : " + schoolService.GetUser());
        }
    }
}