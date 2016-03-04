using System;
using System.Collections.Generic;

namespace FoodOrder.Repository
{
	public class Order
	{
		public Order()
		{
			Consumptions = new List<Consumption>();
		}

		public Guid OrderId { get; set; }
		public DateTime Created { get; set; }


		public virtual User User { get; set; }
		public virtual List<Consumption> Consumptions { get; set; }
	}
}
