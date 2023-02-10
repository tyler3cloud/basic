using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory { HostName = "localhost"};
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "subtract", durable: false, exclusive: false, autoDelete: false, arguments: null);

var continueInput = true;
do
{
    Console.Write("Enter an integer (q to quit): ");
    var input = Console.ReadLine();

    if(input != null && input == "q" || input == "Q")
    {
        continueInput = false;
    }
    else
    {
        var body = Encoding.UTF8.GetBytes(input);
        channel.BasicPublish(exchange: string.Empty, routingKey: "subtract", basicProperties: null, body: body);
        Console.WriteLine($" [x] Sent {input}");
    }
} while (continueInput);