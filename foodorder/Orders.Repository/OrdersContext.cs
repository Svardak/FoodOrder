using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Repository
{
	public class OrdersContext : DbContext
	{
		public OrdersContext() : base((new SqlConnectionStringBuilder(
				ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString)).ToString())
		{ }
		public DbSet<Order> Orders { get; set; }
	}
}
