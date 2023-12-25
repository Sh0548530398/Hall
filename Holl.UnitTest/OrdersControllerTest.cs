using Hall.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holl.UnitTest
{
    public class OrdersControllerTest
    {
        private readonly OrderController _ordersController;
        public OrdersControllerTest()
        {
            var context = new DataContextFake();

           // _ordersController = new OrderController(context);

        }

        [Fact]
        public void GetById_ReturnsOK()
        {
            var id = 0;

            var result = _ordersController.Get(id);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_ReturnsNotFound()
        {
            var id = 5;
            var result = _ordersController.Get(id);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
