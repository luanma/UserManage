﻿using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace UserManage.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        ILog log = log4net.LogManager.GetLogger(typeof(MvcApplication));
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //Log4net
            log4net.Config.XmlConfigurator.Configure();
            log.Info("App Start");
            Application["connStr"] = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        }
        protected void Session_Start()
        {
            log.Info("Session start");
            log.Info("Client IP: "+ Request.UserHostAddress +" , HostName: + " + Request.UserHostName  );            
            log.Info("UserAgent: " + Request.UserAgent);
        }
    }
}
