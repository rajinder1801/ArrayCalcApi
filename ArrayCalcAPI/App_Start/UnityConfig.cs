using System.Web.Http;
using Unity;
using Unity.WebApi;
using ArrayCalcContracts;
using ArrayCalcService;

namespace ArrayCalcAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterSingleton<IArrayOperations, ArrayOperations>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}