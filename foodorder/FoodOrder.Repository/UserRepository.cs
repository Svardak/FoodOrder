using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace FoodOrder.Repository
{
	public class UserRepository
	{
		public void AddOrUpdateUser(User user)
		{
			using (var db = new FoodOrderingContext())
			{
				db.Users.AddOrUpdate(user);
				//db.SaveChanges();
			}
		}

		public void DeleteUser(User user)
		{
			using (var db = new FoodOrderingContext())
			{
				var usr = db.Users.FirstOrDefault(u => u.UserId.Equals(user.UserId));
				db.Users.Remove(usr);
				db.SaveChanges();
			}
		}

		public User GetUser(Guid userId)
		{
			using (var db = new FoodOrderingContext())
			{
				return db.Users.FirstOrDefault(u => u.UserId.Equals(userId));
			}
		}
	}
}
