namespace OrderDispatch.WebApi.Models
{
    public class OrderItem
    {
        public int Count { get; set; }

        public required string ItemName { get; set; }

        public double ItemWeight { get; set; }

        public decimal Cost { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
