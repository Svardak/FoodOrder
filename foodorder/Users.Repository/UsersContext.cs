using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Repository
{
	public class UsersContext : DbContext
	{
		public UsersContext() : base((new SqlConnectionStringBuilder(
				ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString)).ToString())
		{ }
		public DbSet<User> Users { get; set; }
	}
}
