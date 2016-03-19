using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Consumptions.Repository
{
	public class ConsumptionsContext : DbContext
	{
		public ConsumptionsContext() : base((new SqlConnectionStringBuilder(
				ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString)).ToString())
		{ }
		public DbSet<Consumption> Consumptions { get; set; }
	}
}
