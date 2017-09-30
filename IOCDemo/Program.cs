using System;

namespace IOCDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IIocType autofacIocType = new AutoFacIoc();

            IIocType ninjectIocType = new NinjectIoc();
            IIocType castleWindsorIocType = new CastleWindsorIoc();

            autofacIocType.GetCurrentIocType();
            ninjectIocType.GetCurrentIocType();
            castleWindsorIocType.GetCurrentIocType();

            Console.ReadKey();
        }
    }
}