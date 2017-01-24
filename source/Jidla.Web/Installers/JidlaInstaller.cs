using System.Data.Entity;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Jidla.Infrastructure.Data;
using Magrathea;
using Magrathea.Interfaces;

namespace Jidla.Web.Installers
{
    public class JidlaInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IRepository>().ImplementedBy<Repository>(),
                Component.For<DbContext>().ImplementedBy<JidlaContext>()
            );
        }
    }
}