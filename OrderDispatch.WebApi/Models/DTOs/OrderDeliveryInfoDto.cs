using OrderDispatch.WebApi.Attributes;

namespace OrderDispatch.WebApi.Models.DTOs
{
    [AppJsonSerializer]
    public class OrderDeliveryInfoDto
    {
        public DateTime AcceptedAt { get; set; }

        public DateTime PickupAt { get; set; }

        public DateTime DeliveredAt { get; set; }

        public DateTime ArrivedAtStoreAt { get; set; }

        public DateTime CanceledAt { get; set; }

        public DateTime DeliveryTime { get; set; }

        public double DeliveryDistance { get; set; }

        public int EstimatedMinutes { get; set; }
    }
}
