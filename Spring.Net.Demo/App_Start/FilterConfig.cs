using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spring.Net.Demo.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute()); //注释掉系统默认的
            filters.Add(new MyErrorAttribute()); //添加我刚才自定义的
        }
    }
}