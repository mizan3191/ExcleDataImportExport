using Autofac;
using DataImporter.Web.Models.Account;

namespace DataImporter.Web
{
    public class WebModule : Module
    {
        public WebModule()
        {
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegisterModel>().AsSelf();

            base.Load(builder);
        }
    }
}