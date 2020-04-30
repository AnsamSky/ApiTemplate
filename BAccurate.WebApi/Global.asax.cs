﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace BAccurate.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            Framework.IocContainer.Builder();
            GlobalConfiguration.Configuration.Filters.Add(new Extends.AuthFilterAttribute());
        }
    }
}
