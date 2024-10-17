using Microsoft.AspNetCore.Identity;

namespace ProjectK.Models
{
	public class ApplicationUser : IdentityUser
	{
		public ICollection<Order>? Orders { get; set; }
	}
}
