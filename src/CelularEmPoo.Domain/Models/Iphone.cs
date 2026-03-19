using CelularEmPoo.Domain.Abstractions;

namespace CelularEmPoo.Domain.Models;

public sealed class Iphone(string numero, string modelo, string imei, int memoriaGb)
    : Smartphone(numero, modelo, imei, memoriaGb)
{
    public override string InstalarAplicativo(string nomeApp)
    {
        var appNormalizado = NormalizarNomeAplicativo(nomeApp);
        RegistrarInstalacao(appNormalizado);
        return $"iPhone: instalando {appNormalizado} pela App Store.";
    }
}