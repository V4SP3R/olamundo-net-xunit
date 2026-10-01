using MeuPrimeiroTeste.App;

namespace MeuPrimeiroTeste.Tests;

public class OlaMundoTeste
{
    [Fact]
    public void ObterMensagem_DeveRetornarHelloWorld()
    {
        var olaMundo = new OlaMundo();

        var mensagem = olaMundo.ObterMensagem();

        Assert.Equal("Hello, World!", mensagem);
    }
}
