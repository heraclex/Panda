using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace PandaBookStore.WebApp.Initializers
{
    public class AppServiceInitializer
    {
        /// <summary>
        /// Register Dependency Injection
        /// </summary>
        /// <Ref>
        /// https://stackoverflow.com/questions/37988238/asp-net-core-ef-core-dynamically-map-repository-and-services-in-run-time
        /// </Ref>
        public static void RegisterDI(IServiceCollection services)
        {
            // i assume your service interfaces inherit from IService
            Assembly ass = typeof(PandaBookStore.Service.IService).GetTypeInfo().Assembly;

            // get all concrete types which implements IService
            var allServices = ass.GetTypes().Where(t =>
                t.GetTypeInfo().IsClass &&
                !t.GetTypeInfo().IsAbstract &&
                typeof(PandaBookStore.Service.IService).IsAssignableFrom(t));

            foreach (var type in allServices)
            {
                var allInterfaces = type.GetInterfaces();
                var mainInterfaces = allInterfaces.Except
                        (allInterfaces.SelectMany(t => t.GetInterfaces()));
                foreach (var itype in mainInterfaces)
                {
                    if (allServices.Any(x => !x.Equals(type) && itype.IsAssignableFrom(x)))
                    {
                        throw new Exception("The " + itype.Name + " type has more than one implementations, please change your filter");
                    }
                    //services.AddTransient(itype, type);
                    services.AddScoped(itype, type);
                }
            }
        }
    }
}
