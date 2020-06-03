namespace Cafe.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int CoffeeId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Coffee Coffee { get; set; }
        public virtual Order Order { get; set; }
    }
}