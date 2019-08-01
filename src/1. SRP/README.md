
# Single Responsibility Principle – SRP (Coesão)
## Princípio da Responsabilidade Unica

Este é o primeiro princípio do SOLID, um dos mais fáceis de entender e de aplicar. Introduzido por Tom DeMarco no livro **Structured Analysis and Systems Specification** (1979), diz basicamente o seguinte:

> A class should have one, and only one, reason to change

Ou seja, uma classe deve ter **um, e apenas uma**, razão para ser alterada.

Observando o princípio da **coesão funcional**, se uma classe só deve ter um motivo para ser modificada, certamente ela também só deve ter uma única responsabilidade, logo:

Cada **responsabilidade** deve ser uma **classe**, porque uma responsabilidade é um eixo de mudança.

Veja esta classe:

```csharp
public class DebitoContaCorrente
{
    public void ValidarSaldo(int valor) { }

    public void DebitarConta(int valor) { }

    public void EmitirComprovante() { }
}
```

**O que esta classe realmente faz?**

Esta classe **valida saldo em conta** e **debita valor da conta** e **emite comprovante**.

Esta classe possui três responsabilidades, ou seja, ela tem três razões para ser modificada, problemas a vista, vamos imaginar que por algum motivo a regra de negócio da emissão de comprovante mudou, logo para aplicar a nova regra seria necessário modificar a classe DebitoContaCorrente.

Se por um acaso na modificação da classe algum *bug* não identificado foi para a produção não apenas a emissão de comprovante, mas sim todas as funcionalidades da classe poderiam estar comprometidas. O sistema deixaria de fazer o débito devido um problema com o comprovante.

Esse é apenas um exemplo de como o **alto acoplamento** (muitas dependências) pode trazer problemas, testes de unidade seriam muito mais complexos de serem desenvolvidos (e menos eficazes).
Ao modificar esta classe vários testes de integração necessitariam ser executados para garantir que uma funcionalidade não comprometeu as demais.

Alguns benefícios do Princípio de Responsabilidade Única:

* Complexidade do código reduzida, mais explícita e direta;
* Facilitação da legibilidade;
* Redução de acoplamento;
* Código limpo e testável;
* Facilidade de evolução.

**Como deveria ser?**

Veja como a classe poderia ficar após uma refatoração (*refactoring*) da aplicação do Princípio de Responsabilidade Única:

```csharp
public class DebitoContaCorrente
{
    public void DebitarConta(int valor) { }
}

public class SaldoContaCorrente
{
    public void ValidarSaldo(int valor) { }
}

public class ComprovanteContaCorrente
{
    public void EmitirComprovante() { }
}
```

Cada classe tem a sua responsabilidade bem definida.

No início isso pode parecer exagero, mas não é, isto é uma promoção da qualidade do código e uma ótima maneira de obter os benefícios citados acima.

## Conclusão

O Single Responsibility Principle é um dos mais importantes princípios do SOLID, deve ser aplicado para obtermos classes mais coesas e de baixo acoplamento.

Este é o tipo de princípio que todo código orientado a objetos deveria possuir.
Portanto antes de construir aquela classe que cadastra o usuário e envia o e-mail, lembre-se deste princípio.

## Referência

1. [SRP: The Single Responsibility Principle](https://docs.google.com/file/d/0ByOwmqah_nuGNHEtcU5OekdDMkk/edit)