using CelularEmPoo.Domain.Abstractions;
using CelularEmPoo.Domain.Models;

namespace CelularEmPoo.Domain.Tests;

public sealed class SmartphoneBehaviorTests
{
    public static TheoryData<Func<Smartphone>> Smartphones =>
    [
        () => new Nokia("11999999999", "Nokia Edge", "111111111111111", 128),
        () => new Iphone("11988887777", "iPhone 18", "222222222222222", 256)
    ];

    [Theory]
    [MemberData(nameof(Smartphones))]
    public void InstalarAplicativo_QuandoNomeInvalido_DeveLancarExcecao(Func<Smartphone> fabrica)
    {
        var sut = fabrica();

        var ex = Assert.Throws<ArgumentException>(() => sut.InstalarAplicativo("   "));

        Assert.Equal("nomeApp", ex.ParamName);
    }

    [Theory]
    [MemberData(nameof(Smartphones))]
    public void InstalarAplicativo_DeveNormalizarNomeAntesDeRegistrar(Func<Smartphone> fabrica)
    {
        var sut = fabrica();

        _ = sut.InstalarAplicativo("  Signal  ");

        var appInstalado = Assert.Single(sut.AplicativosInstalados);
        Assert.Equal("Signal", appInstalado);
    }
}
