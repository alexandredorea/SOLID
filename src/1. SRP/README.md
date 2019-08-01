
# Single Responsibility Principle � SRP (Coes�o)
## Princ�pio da Responsabilidade Unica

Este � o primeiro princ�pio do SOLID, um dos mais f�ceis de entender e de aplicar. Introduzido por Tom DeMarco no livro **Structured Analysis and Systems Specification** (1979), diz basicamente o seguinte:

> A class should have one, and only one, reason to change

Ou seja, uma classe deve ter **um, e apenas uma**, raz�o para ser alterada.

Observando o princ�pio da **coes�o funcional**, se uma classe s� deve ter um motivo para ser modificada, certamente ela tamb�m s� deve ter uma �nica responsabilidade, logo:

Cada **responsabilidade** deve ser uma **classe**, porque uma responsabilidade � um eixo de mudan�a.

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

Esta classe possui tr�s responsabilidades, ou seja, ela tem tr�s raz�es para ser modificada, problemas a vista, vamos imaginar que por algum motivo a regra de neg�cio da emiss�o de comprovante mudou, logo para aplicar a nova regra seria necess�rio modificar a classe DebitoContaCorrente.

Se por um acaso na modifica��o da classe algum *bug* n�o identificado foi para a produ��o n�o apenas a emiss�o de comprovante, mas sim todas as funcionalidades da classe poderiam estar comprometidas. O sistema deixaria de fazer o d�bito devido um problema com o comprovante.

Esse � apenas um exemplo de como o **alto acoplamento** (muitas depend�ncias) pode trazer problemas, testes de unidade seriam muito mais complexos de serem desenvolvidos (e menos eficazes).
Ao modificar esta classe v�rios testes de integra��o necessitariam ser executados para garantir que uma funcionalidade n�o comprometeu as demais.

Alguns benef�cios do Princ�pio de Responsabilidade �nica:

* Complexidade do c�digo reduzida, mais expl�cita e direta;
* Facilita��o da legibilidade;
* Redu��o de acoplamento;
* C�digo limpo e test�vel;
* Facilidade de evolu��o.

**Como deveria ser?**

Veja como a classe poderia ficar ap�s uma refatora��o (*refactoring*) da aplica��o do Princ�pio de Responsabilidade �nica:

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

No in�cio isso pode parecer exagero, mas n�o �, isto � uma promo��o da qualidade do c�digo e uma �tima maneira de obter os benef�cios citados acima.

## Conclus�o

O Single Responsibility Principle � um dos mais importantes princ�pios do SOLID, deve ser aplicado para obtermos classes mais coesas e de baixo acoplamento.

Este � o tipo de princ�pio que todo c�digo orientado a objetos deveria possuir.
Portanto antes de construir aquela classe que cadastra o usu�rio e envia o e-mail, lembre-se deste princ�pio.

## Refer�ncia

1. [SRP: The Single Responsibility Principle](https://docs.google.com/file/d/0ByOwmqah_nuGNHEtcU5OekdDMkk/edit)