namespace OrderDispatch.WebApi.Models.DTOs
{
    public class OrderItemDto
    {
        public int Count { get; set; }

        public required string ItemName { get; set; }

        public double ItemWeight { get; set; }

        public decimal Cost { get; set; }

        public int OrderId { get; set; }
    }
}
