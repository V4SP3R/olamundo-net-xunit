# olamundo-net-xunit

Lista de exercícios da disciplina **Gestão e Qualidade de Software** (Garantia da Qualidade de Software): uma solução .NET 10 criada via CLI, com um projeto de aplicação e um projeto de testes unitários em xUnit.

## A solução

A solução `MeuPrimeiroTeste` tem dois projetos:

- **MeuPrimeiroTeste.App** — aplicação de console (código de produção). A classe `OlaMundo` expõe o método `ObterMensagem()`, que **retorna** a string `"Hello, World!"` em vez de imprimi-la direto no terminal. É isso que permite testar o método de forma isolada; o `Program.cs` apenas chama o método e escreve o resultado no console.
- **MeuPrimeiroTeste.Tests** — testes unitários com xUnit. A classe `OlaMundoTeste` instancia `OlaMundo`, chama `ObterMensagem()` e valida com `Assert.Equal()` que o resultado é exatamente `"Hello, World!"`.

O projeto de testes referencia o projeto da aplicação, e ambos estão registrados na solução.

```
MeuPrimeiroTeste.slnx
MeuPrimeiroTeste.App/
├── MeuPrimeiroTeste.App.csproj
├── Program.cs
├── OlaMundo.cs
└── HelloWorldService.cs
MeuPrimeiroTeste.Tests/
├── MeuPrimeiroTeste.Tests.csproj
└── OlaMundoTeste.cs
```

> No .NET 10, `dotnet new sln` gera o arquivo de solução no formato `.slnx` (XML), que substitui o antigo `.sln`.

## Tecnologias utilizadas

- [.NET 10](https://dotnet.microsoft.com/) (C#)
- [xUnit](https://xunit.net/) para os testes unitários

## Como executar

Pré-requisito: [SDK do .NET 10](https://dotnet.microsoft.com/download) instalado.

```bash
git clone https://github.com/V4SP3R/olamundo-net-xunit.git
cd olamundo-net-xunit
```

Rodar a aplicação:

```bash
dotnet run --project MeuPrimeiroTeste.App
```

Saída esperada:

```
Hello, World!
```

Rodar os testes:

```bash
dotnet test
```

## Como a solução foi criada

```bash
# 1. Cria a solução
dotnet new sln -n MeuPrimeiroTeste

# 2. Cria o projeto da aplicação (código de produção)
dotnet new console -n MeuPrimeiroTeste.App -f net10.0

# 3. Cria o projeto de testes unitários com xUnit
dotnet new xunit -n MeuPrimeiroTeste.Tests -f net10.0

# 4. Adiciona ambos os projetos à solução
dotnet sln add MeuPrimeiroTeste.App/MeuPrimeiroTeste.App.csproj
dotnet sln add MeuPrimeiroTeste.Tests/MeuPrimeiroTeste.Tests.csproj

# 5. Adiciona a referência do projeto principal dentro do projeto de testes
dotnet add MeuPrimeiroTeste.Tests/MeuPrimeiroTeste.Tests.csproj reference MeuPrimeiroTeste.App/MeuPrimeiroTeste.App.csproj
```

## Licença

Distribuído sob a licença [MIT](LICENSE).
