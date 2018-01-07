using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spring.Net.Demo
{
    public class UserInfo : IUserInfo
    {
        public string UserName { get; set; }
        public Order OrderBy { get; set; }

        public string ShowMsg()
        {
            return "Hello World," + UserName + "的订单号是：" + OrderBy.OrderNo;
        }
    }
    public class Order
    {
        public string OrderNo { get; set; }
    }
}