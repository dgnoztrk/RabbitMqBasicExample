using Core;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Data.Common;
using System.Text;

ConnectionFactory _factory = new ConnectionFactory()
{
    HostName = "localhost",
    UserName = "root",
    Password = "123456"
};
IConnection _connection = _factory.CreateConnection();
var channel = _connection.CreateModel();
channel.QueueDeclare(
    queue: Helper.QueueName,
    durable: false,
    exclusive: false,
    autoDelete: false,
    arguments: null
);

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var jsonString = Encoding.UTF8.GetString(body);
    Console.WriteLine($"Json String : {jsonString}");
};
channel.BasicConsume(queue: Helper.QueueName, autoAck: true, consumer);
Console.ReadKey();