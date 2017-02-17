using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using BAL.Interfaces;
using Models;
using BAL.Facades;
using DAL.Interfaces;
using DAL.Repositories;
using System.Web.Http;

namespace WebTest
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IRepository<Person>, PersonRepository>();
            container.RegisterType<ICRUDFacade<Person>, PersonFacade>();

            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}