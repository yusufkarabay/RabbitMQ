using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

var factory = new ConnectionFactory();
factory.Uri = new Uri("amqps://gbpdqbpc:R6Wr7sQNfJDEe9_PHWFhxjvC73gYhZlg@fish.rmq.cloudamqp.com/gbpdqbpc");
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

var consumer = new EventingBasicConsumer(channel); 
channel.BasicConsume("demo-queue", true, consumer);
consumer.Received += (sender, e) =>
{
    var body = e.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine("Mesajınız: "+message);
};
Console.ReadLine();
