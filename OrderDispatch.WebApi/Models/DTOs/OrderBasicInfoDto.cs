using OrderDispatch.WebApi.Attributes;

namespace OrderDispatch.WebApi.Models.DTOs
{
    [AppJsonSerializer]
    public class OrderBasicInfoDto
    {
        //订单信息
        public required int Id { get; set; }
        public required string OrderNumber { get; set; }

        //费用相关
        public decimal ItemTotal { get; set; }

        public decimal DeliveryFee { get; set; }

        public decimal TotalCost { get; set; }

        public double TotalWeight { get; set; }
    }
}
