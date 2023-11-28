using RabbitMQ.Client;
using System.Text;

var factory = new ConnectionFactory();
factory.Uri = new Uri("amqps://gbpdqbpc:R6Wr7sQNfJDEe9_PHWFhxjvC73gYhZlg@fish.rmq.cloudamqp.com/gbpdqbpc");
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();
channel.QueueDeclare("demo-queue", true, false, false, null);
var message = "Hello World!";
var body = Encoding.UTF8.GetBytes(message);
channel.BasicPublish(string.Empty, "demo-queue", null, body);
Console.WriteLine("Message Sent");
Console.ReadLine();
