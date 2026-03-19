using CelularEmPoo.Domain.Abstractions;
using CelularEmPoo.Domain.Models;

namespace CelularEmPoo.Domain.Tests;

public sealed class SmartphoneChamadaTests
{
    public static TheoryData<Func<Smartphone>> Smartphones =>
    [
        () => new Nokia("11999999999", "Nokia Edge", "111111111111111", 128),
        () => new Iphone("11988887777", "iPhone 18", "222222222222222", 256)
    ];

    [Theory]
    [MemberData(nameof(Smartphones))]
    public void Ligar_DeveRetornarMensagemDeLigacao(Func<Smartphone> fabrica)
    {
        var sut = fabrica();

        var mensagem = sut.Ligar();

        Assert.Equal("Ligando...", mensagem);
    }

    [Theory]
    [MemberData(nameof(Smartphones))]
    public void ReceberLigacao_DeveRetornarMensagemDeRecebimento(Func<Smartphone> fabrica)
    {
        var sut = fabrica();

        var mensagem = sut.ReceberLigacao();

        Assert.Equal("Recebendo ligação...", mensagem);
    }
}
