using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiApp
{
    [Route("orders")]
    public class OrdersController : ApiController
    {

        public Order[] GetOrders()
        {
            return new[]
            {
                new Order()
                {
                    Id = 1,
                    CreatedDate = new DateTime(2013, 1, 5),
                    Number = "124356",
                    Price = 1257.89m
                },
                new Order()
                {
                    Id = 1,
                    CreatedDate = new DateTime(2014, 2, 7),
                    Number = "667233",
                    Price = 6572.34m
                }
            };
        }

    }
}