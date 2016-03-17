using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Migrations;
using System.Linq;

namespace FoodOrder.Repository
{
	public class OrderRepository
	{
		public Order GetOrderByUserAndDate(Guid userId, DateTime orderDate)
		{
			using (var db = new FoodOrderingContext())
			{
				return db.Orders.FirstOrDefault(
						o => DbFunctions.CreateDateTime(o.Created.Year, o.Created.Month, o.Created.Day, 0, 0, 0) == orderDate.Date &&
						o.User.UserId == userId);
			}
		}

		public void DeleteOrder(Order order)
		{
			using (var db = new FoodOrderingContext())
			{
				var ord = db.Orders.FirstOrDefault(o => o.OrderId.Equals(order.OrderId));
				db.Orders.Remove(ord);
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
