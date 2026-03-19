using CelularEmPoo.Domain.Abstractions;

namespace CelularEmPoo.Domain.Models;

public sealed class Nokia(string numero, string modelo, string imei, int memoriaGb)
    : Smartphone(numero, modelo, imei, memoriaGb)
{
    public override string InstalarAplicativo(string nomeApp)
    {
        var appNormalizado = NormalizarNomeAplicativo(nomeApp);
        RegistrarInstalacao(appNormalizado);
        return $"Nokia: instalando {appNormalizado} pela Loja Nokia.";
    }
}