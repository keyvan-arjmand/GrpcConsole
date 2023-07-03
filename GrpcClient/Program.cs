
using Grpc.Net.Client;
using GrpcClient;

Console.WriteLine("Perss your name : ");
string name = Console.ReadLine();
using var Channel = GrpcChannel.ForAddress("http://localhost:5242");
var client = new Greeter.GreeterClient(Channel);
var reply = await client.SayHelloAsync(new HelloRequest { Name = name });
Console.WriteLine($"Greetings : {reply.Message}");

Console.WriteLine("Perss Any Ket to Exist");
