using CelularEmPoo.Domain.Abstractions;
using CelularEmPoo.Domain.Models;

namespace CelularEmPoo.Domain.Tests;

public sealed class SmartphoneEstadoChamadaTests
{
    public static TheoryData<Func<Smartphone>> Smartphones =>
    [
        () => new Nokia("11999999999", "Nokia Edge", "111111111111111", 128),
        () => new Iphone("11988887777", "iPhone 18", "222222222222222", 256)
    ];

    [Theory]
    [MemberData(nameof(Smartphones))]
    public void Apos_Ligar_EstadoDeveSer_EmLigacao(Func<Smartphone> fabrica)
    {
        var sut = fabrica();

        _ = sut.Ligar();

        Assert.True(sut.EmLigacao, "O telefone deve estar em ligação após chamar Ligar().");
    }

    [Theory]
    [MemberData(nameof(Smartphones))]
    public void Apos_ReceberLigacao_EstadoDeveSer_EmLigacao(Func<Smartphone> fabrica)
    {
        var sut = fabrica();

        _ = sut.ReceberLigacao();

        Assert.True(sut.EmLigacao, "O telefone deve estar em ligação após chamar ReceberLigacao().");
    }

    [Theory]
    [MemberData(nameof(Smartphones))]
    public void FinalizarLigacao_DeveColocarEmRepouso(Func<Smartphone> fabrica)
    {
        var sut = fabrica();
        _ = sut.Ligar();

        sut.FinalizarLigacao();

        Assert.False(sut.EmLigacao, "O telefone deve estar em repouso após finalizar ligação.");
    }
}
