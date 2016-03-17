using System;
using System.Collections.Generic;
using FoodOrder.Repository;
using NUnit.Framework;

namespace FoodOrderTests
{
	[TestFixture]
	public class DatabaseTests
	{
		[Test]
		public void CreateDatabaseForClasses()
		{
			var date = DateTime.Now;
			var user = CreateUser("test", "test");
			var consumption = CreateConsumption("stuff to eat");

			var consumptions = new List<Consumption> {consumption};
			var order = CreateOrder(user, consumptions, date);

			var storedOrder = GetOrderByUserAndDate(user, date);
			Assert.That(storedOrder, Is.EqualTo(order));

			GetRidOfTheTestData(user, consumption, order);
		}

		private static void GetRidOfTheTestData(User user, Consumption consumption, Order order)
		{
			var userRepository = new UserRepository();
			var consumptionRepository = new ConsumptionRepository();
			var orderRepository = new OrderRepository();

			userRepository.DeleteUser(user);
			consumptionRepository.DeleteConsumption(consumption);
			orderRepository.DeleteOrder(order);
		}

		private static Order CreateOrder(User user, List<Consumption> consumptions, DateTime date)
		{
			var order = new Order
			{
				OrderId = Guid.NewGuid(),
				Created = date,
				User = user,
				Consumptions = consumptions
			};

			AddOrUpdateOrder(order);
			return order;
		}

		private static User CreateUser(string name, string mail)
		{
			var repository = new UserRepository();
			var user = new User
			{
				UserId = Guid.NewGuid(),
				Name = name,
				MailAddress = mail
			};
			repository.AddOrUpdateUser(user);

			return user;
		}

		private static Consumption CreateConsumption(string description)
		{
			var consumptionRepository = new ConsumptionRepository();
			var consumption = new Consumption { ConsumptionId = Guid.NewGuid(), Description = "Test1" };

			consumptionRepository.AddOrUpdateConsumption(consumption);
			return consumption;
		}

		private static void AddOrUpdateOrder(Order order)
		{
			var orderRepository = new OrderRepository();
			orderRepository.AddOrUpdateOrder(order);
		}

		private Order GetOrderByUserAndDate(User user, DateTime date)
		{
			var orderRepository = new OrderRepository();
			return orderRepository.GetOrderByUserAndDate(user, date);
		}
	}
}
