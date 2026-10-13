# Blazor DBZ Personagem

Aplicação web feita com Blazor para consultar personagens de Dragon Ball. A página permite informar o ID de um personagem e consultar seu nome, planeta de origem e transformações usando a [Dragon Ball API](https://dragonball-api.com/).

## Funcionalidades

- Busca de personagem pelo ID.
- Exibição do nome e do planeta de origem.
- Listagem das transformações, quando disponíveis.
- Mensagem de carregamento e aviso quando a consulta não retorna um personagem.

## Tecnologias

- C# e ASP.NET Core
- Blazor Web App com renderização interativa no servidor
- .NET 10
- Dragon Ball API

## Pré-requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Acesso à internet para consultar a API

## Como executar

Na pasta raiz do repositório, execute:

```powershell
cd BlazorDbzPersonagem
dotnet run
```

O perfil HTTP está configurado em `http://localhost:5142` e o perfil HTTPS em `https://localhost:7144`. Acesse a página de consulta em `/personagem`, por exemplo:

- `http://localhost:5142/personagem`
- `https://localhost:7144/personagem`

Para compilar sem iniciar a aplicação:

```powershell
dotnet build BlazorDbzPersonagem/BlazorDbzPersonagem.csproj
```

## Como usar

1. Abra a página `/personagem`.
2. Informe o ID desejado no campo **ID do personagem**.
3. Clique em **Buscar**.

## API utilizada

O serviço consulta `https://dragonball-api.com/api/characters/{id}`. A URL base está configurada em `BlazorDbzPersonagem/Program.cs`.
