using ClienteGRPC;
using Grpc.Net.Client;
using GrpcClienteService;


class Program
{
    static async Task Main(string[] args)
    {
        // Criar um canal para o servidor gRPC
        var channel = GrpcChannel.ForAddress("https://localhost:7175");

        // Criar o cliente gRPC gerado a partir do .proto
        var client = new Greeter.GreeterClient(channel);

        // Fazer a chamada ao método SayHello
        var reply = await client.SayHelloAsync(new HelloRequest { Name = "Elson Costa" });

        // Exibir a resposta no console
        Console.WriteLine("Saudação: " + reply.Message);
        
        

        // Criar o cliente gRPC
        var client2 = new ClienteService.ClienteServiceClient(channel);

        // Criar um novo cliente para enviar ao servidor
        var novoCliente = new Cliente
        {
            Id = 1,
            Nome = "Elson Costa",
            Email = "elson.costa@gmail.com"
        };

        // Fazer a chamada gRPC para o servidor
        var response = await client2.CreateClienteAsync(novoCliente);

        // Exibir a resposta do servidor
        Console.WriteLine($"Resposta do servidor: {response.Mensagem}");
        Console.WriteLine($"Resposta do servidor: {response.Sucesso}");
    }
}
