using OrderDispatch.WebApi.Attributes;

namespace OrderDispatch.WebApi.Models.DTOs
{
    [AppJsonSerializer]
    public class RiderDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }

        public bool IsFullOrder { get; set; }

        public RiderState State { get; set; } = RiderState.Offline;
    }
}
