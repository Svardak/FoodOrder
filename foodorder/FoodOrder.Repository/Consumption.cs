using System;

namespace FoodOrder.Repository
{
	public class Consumption
	{
		public Guid ConsumptionId { get; set; }
		public string Description { get; set; }
		public virtual  Order Order { get; set; }
	}
}