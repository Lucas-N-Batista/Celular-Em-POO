namespace CelularEmPoo.Domain.Abstractions;

public abstract class Smartphone(string numero, string modelo, string imei, int memoriaGb)
{
    private readonly List<string> _aplicativosInstalados = [];
    private bool _emLigacao = false;

    public string Numero { get; } = numero;
    public string Modelo { get; } = modelo;
    public string Imei { get; } = imei;
    public int MemoriaGb { get; } = memoriaGb;
    public IReadOnlyList<string> AplicativosInstalados => _aplicativosInstalados;
    public bool EmLigacao => _emLigacao;

    public virtual string Ligar()
    {
        _emLigacao = true;
        return "Ligando...";
    }

    public virtual string ReceberLigacao()
    {
        _emLigacao = true;
        return "Recebendo ligação...";
    }

    public virtual void FinalizarLigacao()
    {
        _emLigacao = false;
    }

    protected void RegistrarInstalacao(string nomeApp) => _aplicativosInstalados.Add(nomeApp);

    protected static string NormalizarNomeAplicativo(string nomeApp)
    {
        if (string.IsNullOrWhiteSpace(nomeApp))
        {
            throw new ArgumentException("O nome do aplicativo deve ser informado.", nameof(nomeApp));
        }

        return nomeApp.Trim();
    }

    public abstract string InstalarAplicativo(string nomeApp);
}