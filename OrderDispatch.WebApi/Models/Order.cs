using Microsoft.EntityFrameworkCore;

namespace OrderDispatch.WebApi.Models
{
    public class Order
    {
        //订单信息
        public required int Id { get; set; }
        public required string OrderNumber { get; set; }

        //收货人信息
        public required string CustomerName { get; set; }
        public required string CustomerPhone { get; set; }
        public string CustomerNote { get; set; }

        public List<OrderItem> Items { get; set; } = [];

        //费用相关
        public decimal ItemTotal { get; set; }

        public decimal DeliveryFee { get; set; }

        public decimal TotalCost { get; set; }

        public double TotalWeight { get; set; }

        //配送信息
        public string DeliveryAddress { get; set; }

        public double DeliveryDistance { get; set; }

        public int EstimatedMinutes { get; set; }

        public int BusinessId { get; set; }

        public Business Business { get; set; }

        //时间戳
        public DateTime CreateAt { get; set; } = DateTime.Now;

        public DateTime AcceptedAt { get; set; }

        public DateTime PickupAt { get; set; }

        public DateTime DeliveredAt { get; set; }

        public DateTime ArrivedAtStoreAt { get; set; }

        public DateTime CanceledAt { get; set; }

        public DateTime DeliveryTime { get; set; }

        public DeliveryState State { get; set; } = DeliveryState.Pending;

        //骑手信息
        public int? RiderId { get; set; }

        public Rider? Rider { get; set; }
        public string RiderName { get; set; }

        public string RiderPhone { get; set; }


        //订单异常原因
        public string? FailureReason { get; set; }
    }
}
