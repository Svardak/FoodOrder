using System.Data.Entity;

namespace FoodOrder.Repository
{
	public class FoodOrderingContext : DbContext
	{
		public DbSet<Consumption> Consumptions { get; set; }
	}
}