using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace FoodOrder.Repository
{
	public class ConsumptionRepository
	{
		public void AddOrUpdateConsumption(Consumption consumption)
		{
			using (var db = new FoodOrderingContext())
			{
				db.Consumptions.AddOrUpdate(consumption);
				db.SaveChanges();
			}
		}

		public void DeleteConsumption(Consumption consumption)
		{
			using (var db = new FoodOrderingContext())
			{
				db.Consumptions.Remove(consumption);
				db.SaveChanges();
			}
		}
	}
}