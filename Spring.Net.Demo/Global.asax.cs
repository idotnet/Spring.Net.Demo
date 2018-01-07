using Spring.Net.Demo.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using log4net;

namespace Spring.Net.Demo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            ThreadPool.QueueUserWorkItem(o =>
            {
                while (true)
                {
                    if (MyErrorAttribute.ExceptionQueue.Count > 0)
                    {
                        Exception ex = MyErrorAttribute.ExceptionQueue.Dequeue();
                        if (ex != null)
                        {
                            ILog logger = LogManager.GetLogger("testError");
                            logger.Error(ex.ToString()); //将异常信息写入Log4Net中  
                        }
                        else
                        {
                            Thread.Sleep(50);
                        }
                    }
                    else
                    {
                        Thread.Sleep(50);
                    }
                }
            });
        }
    }
}
