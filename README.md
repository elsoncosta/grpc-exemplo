# gRPC Cliente-Servidor em .NET

Este projeto demonstra a implementação de uma API gRPC utilizando o .NET 8. A aplicação inclui um serviço gRPC para manipulação de clientes (CRUD), no qual um objeto `Cliente` pode ser enviado por um cliente gRPC para o servidor, que o processa e retorna uma resposta.

## O que é gRPC?

gRPC (Remote Procedure Call, ou Chamada de Procedimento Remoto) é um framework de RPC de código aberto desenvolvido pela Google. Ele utiliza **Protocol Buffers (protobuf)** como mecanismo de serialização de dados e comunica serviços de maneira eficiente e escalável. Diferente das APIs REST, que usam HTTP 1.x, o gRPC utiliza **HTTP/2**, o que oferece diversos benefícios:

- **Comunicação bidirecional**: suporte para streams de dados do cliente para o servidor e vice-versa.
- **Desempenho otimizado**: utiliza HTTP/2 e Protocol Buffers, tornando o gRPC mais rápido em comparação às APIs baseadas em JSON.
- **Contratos fortes**: definição de serviços e mensagens fortemente tipados via arquivos `.proto`.

## Arquitetura do Projeto

- **Servidor gRPC**: Implementa o serviço gRPC que recebe um objeto `Cliente` e responde com um status de criação.
- **Cliente gRPC**: Envia o objeto `Cliente` via chamada gRPC para o servidor.

### Estrutura do Projeto

- **Protos/**: Contém o arquivo `.proto`, que define o serviço e as mensagens gRPC.
- **Servidor gRPC**: Implementa o serviço para manipular os dados recebidos.
- **Cliente gRPC**: Envia dados para o servidor gRPC e recebe as respostas.

## Requisitos

- .NET 8 SDK ou superior
- `dotnet-grpc` CLI para trabalhar com arquivos `.proto`
- Certificados SSL para rodar o servidor gRPC localmente via HTTPS

## Como Executar o Projeto

### Passo 1: Clonar o Repositório

```bash
git clone git@github.com:elsoncosta/grpc-exemplo.git
cd src/GRPCWebApi/
```

```bash
dotnet dev-certs https --trust
```

### Passo 2: Cliente

```bash
cd src/ClienteGRPC/
dotnet run
```
