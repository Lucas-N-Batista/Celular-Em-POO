# Celular Em POO

Projeto em C# para demonstrar conceitos de programacao orientada a objetos a partir de uma hierarquia de smartphones.

## Objetivo

O projeto modela um smartphone abstrato e duas implementacoes concretas:

- `Nokia`
- `Iphone`

Cada aparelho compartilha comportamentos basicos de chamada e instalacao de aplicativos, enquanto especializa a forma como os apps sao instalados.

## Conceitos aplicados

- Abstracao com a classe base `Smartphone`
- Heranca com `Nokia` e `Iphone`
- Polimorfismo no metodo `InstalarAplicativo`
- Encapsulamento do estado de ligacao e da lista de aplicativos instalados
- Testes automatizados com xUnit

## Estrutura da solucao

```text
src/
  CelularEmPoo.ConsoleApp/   Aplicacao de console
  CelularEmPoo.Domain/       Regras de dominio
tests/
  CelularEmPoo.Domain.Tests/ Testes automatizados
```

## Regras implementadas

- Um smartphone possui numero, modelo, IMEI e memoria em GB
- `Ligar()` retorna `Ligando...` e altera o estado para em ligacao
- `ReceberLigacao()` retorna `Recebendo ligação...` e altera o estado para em ligacao
- `FinalizarLigacao()` coloca o aparelho em repouso
- A instalacao de aplicativos normaliza espacos extras no nome informado
- Nomes vazios ou em branco geram excecao
- `Iphone` instala apps pela `App Store`
- `Nokia` instala apps pela `Loja Nokia`

## Requisitos

- .NET SDK `10.0.104` ou superior compativel com `net10.0`

## Como executar

Restaurar dependencias:

```bash
dotnet restore
```

Executar a aplicacao de console:

```bash
dotnet run --project src/CelularEmPoo.ConsoleApp
```

Executar os testes:

```bash
dotnet test
```

## Testes

Os testes cobrem:

- mensagens retornadas em chamadas
- transicoes de estado da ligacao
- instalacao de aplicativos por tipo de aparelho
- validacao e normalizacao do nome do aplicativo

## Observacao

A aplicacao de console esta minima no momento e pode ser expandida para demonstrar o uso das classes do dominio em tempo de execucao.