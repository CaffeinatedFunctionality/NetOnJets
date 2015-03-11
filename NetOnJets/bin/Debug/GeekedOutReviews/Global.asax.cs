using System;
using System.Web;
using GeekedOutReviews.Controllers;
using Ninject;
using Ninject.Web.Common;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using GeekedOutReviews.Core;
using GeekedOutReviews.Core.Objects;

namespace GeekedOutReviews
{
   public class MvcApplication : NinjectHttpApplication
   {
    protected override IKernel CreateKernel()
    {
      var kernel = new StandardKernel();

      kernel.Load(new RepositoryModule());
      kernel.Bind<IBlogRepository>().To<BlogRepository>();

      return kernel;
    }

    protected override void OnApplicationStarted()
    {
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);

      base.OnApplicationStarted();
    }
  }
}
