using System;
using System.Collections.Generic;

namespace Orders.Repository
{
	public class Order
	{
		public Order()
		{
			ConsumptionIds = new List<Guid>();
      }

		public Guid OrderId { get; set; }
		public DateTime Created { get; set; }
		public Guid UserId { get; set; }
		public List<Guid> ConsumptionIds { get; set; }
	}
}