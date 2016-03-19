using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;

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
