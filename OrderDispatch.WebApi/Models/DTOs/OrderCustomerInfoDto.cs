namespace OrderDispatch.WebApi.Models.DTOs
{
    public class OrderCustomerInfoDto
    {
        //收货人信息
        public required string CustomerName { get; set; }
        public required string CustomerPhone { get; set; }
        public string CustomerNote { get; set; }
        //配送信息
        public string DeliveryAddress { get; set; }
    }
}
