using Grpc.Net.Client;
using gRoom.gRPC.Messages;

using var channel = GrpcChannel.ForAddress("http://localhost:5210/");
var client = new Groom.GroomClient(channel);

Console.Write("Enter your room name");
var roomName = Console.ReadLine();

var response = client.RegisterToRoom(new RoomRegistrationRequest { RoomName = roomName });
Console.WriteLine($"Room id is: {response}");

Console.ReadLine();

