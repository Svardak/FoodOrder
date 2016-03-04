using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using FoodOrder.Models;

namespace FoodOrder.Controllers
{
	public class OrderController : ApiController
	 {
		[ResponseType(typeof(Order))]
		public async Task<IHttpActionResult> Get()
		{
			return this.Ok(new Order());
		}

		[ResponseType(typeof(Order))]
		public async Task<IHttpActionResult> Post(Order order)
		{
			if (!ModelState.IsValid)
			{
				return this.BadRequest(this.ModelState);
			}

			return this.Ok<bool>(true);
		}
	}
}
