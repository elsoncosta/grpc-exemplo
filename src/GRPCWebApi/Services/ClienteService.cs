using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcClienteService;

namespace GRPCWebApi.Services
{
public class ClienteService : GrpcClienteService.ClienteService.ClienteServiceBase
{
    public override Task<ClienteResponse> CreateCliente(Cliente request, ServerCallContext context)
    {
        // Lógica para salvar o cliente, por exemplo, no banco de dados
        Console.WriteLine($"Cliente recebido: {request.Nome}, {request.Email}");

        // Retornar uma resposta de sucesso
        return Task.FromResult(new ClienteResponse
        {
            Sucesso = true,
            Mensagem = "Cliente criado com sucesso!"
        });
    }
}

}