using Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMqCustomer.Models;
using System.Text;

namespace RabbitMqCustomer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RabbitMqController : ControllerBase
    {
        private readonly ConnectionFactory _factory;
        private readonly IConnection _connection;
        public RabbitMqController(/*ConnectionFactory factory,IConnection connection*/)
        {
            //_factory factory;
            _factory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "root",
                Password = "123456"
            };
            _connection = _factory.CreateConnection();
        }

        [HttpPost]
        public async Task<IActionResult> Test(TestViewModel model)
        {
            var customer = new
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Email = model.Email
            };
            using (var channel = _connection.CreateModel())
            {
                channel.QueueDeclare(
                    queue: Helper.QueueName,
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null
                );
                var customerPayload = JsonConvert.SerializeObject(customer);
                var body = Encoding.UTF8.GetBytes(customerPayload);

                channel.BasicPublish(
                    exchange: "",
                    routingKey: Helper.routingKey,
                    basicProperties: null,
                    body: body
                );
            }
            return Ok(customer);
        }
    }
}
