using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumptions.Repository
{
	public class ConsumptionsContext : DbContext
	{
		public ConsumptionsContext() : base((new SqlConnectionStringBuilder(
				ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString)).ToString())
		{ }
		public DbSet<Consumption> Orders { get; set; }
	}
}
