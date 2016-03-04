using System;
using System.Collections.Generic;

namespace FoodOrder.Repository
{
	public class User
	{
		public Guid UserId { get; set; }
		public string Name { get; set; }
		public string MailAddress { get; set; }
	}
}
