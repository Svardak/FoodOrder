using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FoodOrder.Repository
{
	public class ConsumptionRepository
	{
		public void AddConsumption(string name, string description)
		{
			var consumption = new Consumption
			{
				ConsumptionId = new Guid(),
				Name = name,
				Description = description
			};

			using (var db = new FoodOrderingContext())
			{
				db.Consumptions.Add(consumption);
				db.SaveChanges();
			}
		}

		public void RemoveConsumption(Consumption consumption)
		{
			using (var db = new FoodOrderingContext())
			{
				db.Consumptions.Remove(consumption);
				db.SaveChanges();
			}
		}

		public void UpdateConsumption(Consumption consumption)
		{
			using (var db = new FoodOrderingContext())
			{
				db.Consumptions.Attach(consumption);
				db.Entry(consumption).State = EntityState.Modified;
				db.SaveChanges();
			}
		}

		public List<Consumption> GetAllConsumptions()
		{
			List<Consumption> consumptions;

			using (var db = new FoodOrderingContext())
			{
				consumptions = db.Consumptions.ToList();
			}

			return consumptions;
		}
	}
}