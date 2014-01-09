namespace SharpArchTemplate.Web.Mvc.CastleWindsor
{
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    public class QueryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes.FromAssemblyNamed("SharpArchTemplate.Web.Mvc")
                    .InNamespace("SharpArchTemplate.Web.Mvc.Controllers.Queries", true)
                    .WithService.DefaultInterfaces()
                    .LifestylePerWebRequest());
        }
    }
}