namespace Spring.Net.Demo
{
    public class NewUserInfo : IUserInfo
    {
        public NewUserInfo(string name, Order order)
        {
            this.UserName = name;
            this.OrderBy = order;
        }
        public string UserName { get; set; }
        public Order OrderBy { get; set; }
        public string ShowMsg()
        {
            return "Hello World，" + UserName + "的订单号是：" + OrderBy.OrderNo;
        }
    }
}