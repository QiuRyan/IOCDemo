// *********************************************************************** Assembly : WebApp Author :
// qiu.yanjun Created : 09-30-2017
//
// Last Modified By : qiu.yanjun Last Modified On : 09-30-2017
// ***********************************************************************
// <copyright file="AutofacConfig.cs" company="">
//     Copyright © 2017
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using IOC.Demo.Lib;

/// <summary>
/// The WebApp namespace.
/// </summary>
namespace WebApp
{
    /// <summary>
    /// Class AutofacConfig.
    /// </summary>
    public static class AutofacConfig
    {
        /// <summary>
        /// Registers this instance.
        /// </summary>
        public static void Register()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); //注册api容器的实现

            builder.RegisterType(typeof(UserService)).As<IUser>();
            builder.RegisterType(typeof(SchoolService)).As<ISchool>();

            IContainer container = builder.Build();
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}