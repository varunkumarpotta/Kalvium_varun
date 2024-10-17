namespace ProjectK.Models
{
	public class Order
	{
		public int OrderId { get; set; }
		public DateTime OrderDate { get; set; }
		public string? UserId { get; set; }
		public ApplicationUser User { get; set; }
		public int TotalAmount { get; set; }
		public ICollection<OrderItem>? orderItems { get; set; }
	}
}
