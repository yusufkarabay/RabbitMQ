using RabbitMQ.Client;

var factory = new ConnectionFactory();
factory.Uri = new Uri("amqps://gbpdqbpc:R6Wr7sQNfJDEe9_PHWFhxjvC73gYhZlg@fish.rmq.cloudamqp.com/gbpdqbpc");
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();
