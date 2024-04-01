namespace MovieApp.Models.DTO
{
    public class OrderDTO
    {
        public List<TicketInOrder>? AllTickets { get; set; }
        public double? TotalPrice { get; set; }


    }
}
