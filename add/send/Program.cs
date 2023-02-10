using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory { HostName = "localhost"};
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();


channel.QueueDeclare(queue: "add", durable: false, exclusive: false, autoDelete: false, arguments: null);
const string message = "1";
var body = Encoding.UTF8.GetBytes(message);

channel.BasicPublish(exchange: string.Empty, routingKey: "add", basicProperties: null, body: body);
Console.WriteLine($" [x] Sent {message}");

Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();