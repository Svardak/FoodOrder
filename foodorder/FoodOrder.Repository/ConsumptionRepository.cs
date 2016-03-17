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
				//db.SaveChanges();
			}
		}

		public Consumption GetConsumption(Guid consumptionId)
		{
			using (var db = new FoodOrderingContext())
			{
				return db.Consumptions.FirstOrDefault(c => c.ConsumptionId.Equals(consumptionId));
			}
		}

		public void DeleteConsumption(Consumption consumption)
		{
			using (var db = new FoodOrderingContext())
			{
				var cons = db.Consumptions.FirstOrDefault(c => c.ConsumptionId.Equals(consumption.ConsumptionId));
				db.Consumptions.Remove(cons);
				db.SaveChanges();
			}
		}
	}
}