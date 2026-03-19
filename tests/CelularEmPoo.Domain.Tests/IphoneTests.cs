using CelularEmPoo.Domain.Models;

namespace CelularEmPoo.Domain.Tests;

public sealed class IphoneTests
{
    [Fact]
    public void InstalarAplicativo_DeveRegistrarAppERetornarMensagemDaAppStore()
    {
        var sut = new Iphone("11988887777", "iPhone 18", "987654321098765", 256);

        var mensagem = sut.InstalarAplicativo("Instagram");

        Assert.Equal("iPhone: instalando Instagram pela App Store.", mensagem);
        var appInstalado = Assert.Single(sut.AplicativosInstalados);
        Assert.Equal("Instagram", appInstalado);
    }
}