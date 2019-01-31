using Autofac;
using Autofac.Builder;
using Autofac.Integration.WebApi;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Web;
using Zero.model;
using Zero.Manager.EntityManager;
using Zero.Manager.IManager;
namespace Zero.Web.Api.App_Start
{
    public static class AutoFacConfig
    {
        /// <summary>
        /// this class to resolve dependancy.
        /// </summary>
        /// <returns></returns>
        public static IContainer Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<WebApiApplication>().InstancePerDependency();

            builder.RegisterType<ModelContext>().AsSelf().As<IZeroContext>().InstancePerRequest();
            builder.RegisterGeneratedFactory<ModelContext.Factory>().InstancePerRequest();

            builder.RegisterType<ZeroContextFactroy>().As<IZeroContextFactory>().InstancePerRequest();

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies()).Where(t => t.Name.EndsWith("Manager"))
                .FindConstructorsWith((type) =>
                {
                    return type.GetConstructors().Where(e =>
                    {
                        return !(e.GetParameters().Where(r => r.ParameterType == typeof(ModelContext)).Count() > 0);
                    }).ToArray();
                })
                .AsImplementedInterfaces();

            return builder.Build();
        }
    }
}