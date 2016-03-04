using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;

namespace FoodOrder.Repository
{
	public class FoodOrderingContext : DbContext
	{
		public FoodOrderingContext() : base((new SqlConnectionStringBuilder(
				ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString)).ToString())
		{}
		public DbSet<Consumption> Consumptions { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Order> Orders { get; set; }
	}
}