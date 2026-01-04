namespace OrderDispatch.WebApi.Models.DTOs
{
    public class OrderDto
    {
        public OrderBasicInfoDto OrderInfo { get; set; }

        public OrderCustomerInfoDto CustomerInfo { get; set; }

        public BusinessDto BusinessInfo {  get; set; }
        //时间戳
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DeliveryState State { get; set; } = DeliveryState.Pending;
        //骑手信息
        public RiderDto RiderInfo { get; set; }
        //订单异常原因
        public string? FailureReason { get; set; }
        public List<OrderItem> Items { get; set; } = [];
    }
}
