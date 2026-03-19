using CelularEmPoo.Domain.Models;

namespace CelularEmPoo.Domain.Tests;

public sealed class NokiaTests
{
    [Fact]
    public void InstalarAplicativo_DeveRegistrarAppERetornarMensagemDaLojaNokia()
    {
        var sut = new Nokia("11999999999", "Tijolao Pro", "123456789012345", 128);

        var mensagem = sut.InstalarAplicativo("WhatsApp");

        Assert.Equal("Nokia: instalando WhatsApp pela Loja Nokia.", mensagem);
        var appInstalado = Assert.Single(sut.AplicativosInstalados);
        Assert.Equal("WhatsApp", appInstalado);
    }
}