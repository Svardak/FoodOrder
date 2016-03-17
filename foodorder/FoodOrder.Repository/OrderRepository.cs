using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace FoodOrder.Repository
{
	public class OrderRepository
	{
		public Order GetOrderByUserAndDate(User user, DateTime orderDate)
		{
			using (var db = new FoodOrderingContext())
			{
				return db.Orders.FirstOrDefault(
						o => /*o.Created.Date == orderDate.Date &&*/
								o.User.UserId == user.UserId);
			}
		}

		public void DeleteOrder(Order order)
		{
			using (var db = new FoodOrderingContext())
			{
				db.Orders.Remove(order);
				db.SaveChanges();
			}
		}

		public void AddOrUpdateOrder(Order order)
		{
			using (var db = new FoodOrderingContext())
			{
				db.Orders.AddOrUpdate(order);
				db.SaveChanges();
			}
		}
	}
}
