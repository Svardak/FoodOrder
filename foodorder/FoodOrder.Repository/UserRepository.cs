using System;
using System.Data.Entity.Migrations;

namespace FoodOrder.Repository
{
	public class UserRepository
	{
		public void AddOrUpdateUser(User user)
		{
			using (var db = new FoodOrderingContext())
			{
				db.Users.AddOrUpdate(user);
				db.SaveChanges();
			}
		}

		public void DeleteUser(User user)
		{
			using (var db = new FoodOrderingContext())
			{
				db.Users.Remove(user);
				db.SaveChanges();
			}
		}
	}
}
