using Grpc.Net.Client;
using GrpcClient;
using Type = GrpcClient.Type;

using var Channel = GrpcChannel.ForAddress("http://localhost:5242");
var client = new Greeter.GreeterClient(Channel);

Console.WriteLine("Perss your name : ");
string? name = Console.ReadLine();

var reply = await client.SayHelloAsync(new HelloRequest { Name = name });
Console.WriteLine($"Greetings : {reply.Message}");
Console.WriteLine("Perss Any Ket to Create User");

User user = new User
{
    Name = name,
    Email = "keyvan@gmail.com",
    Type = Type.Gold,
    Details = new Details
    {
        Address = "Test Address Grpc",
        PhoneNumber = "0921129482"
    }
};
Respnse State = client.CreateUser(user);

if (State.State)
{
    Console.WriteLine("Ok");
}
else
{
    Console.WriteLine("Error");
}
