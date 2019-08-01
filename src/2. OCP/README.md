# Open Closed Principle � OCP
## Princ�pio Aberto-Fechado


Este � o segundo princ�pio do SOLID e certamente o princ�pio mais pol�mico, desconhecido e n�o utilizado. Descrito por [Bertrand Meyer] (1988), diz basicamente o seguinte:

> Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification

Entidades de software (classes, m�dulos, fun��es, etc) devem estar abertas para extens�o, mas fechadas para modifica��o. Em outra palavras, voc� deve ser capaz de estender um comportamento de uma classe, sem modific�-lo.

Softwares s�o evolutivos, raramente um software � feito uma vez e nunca mais ser� modificado. 

> *"O Open Closed Principle, afirma que a concep��o e escrita do c�digo devem ser feita de uma forma que a nova funcionalidade deve ser adicionada com mudan�as m�nimas no c�digo existente; que o projeto deve ser feito de forma a permitir a adi��o de novas funcionalidades como as novas classes, mantendo tanto quanto poss�vel o c�digo existente inalterado."*


## Onde esse princ�pio tenta chegar?


**Extensibilidade**

� uma das chaves da orienta��o a objetos, quando **um novo comportamento ou funcionalidade precisar ser adicionado** � esperado que **as existentes sejam estendidas** e **n�o alteradas**, assim o c�digo original permanece intacto e confi�vel enquanto as novas s�o implementadas atrav�s de extensibilidade. Criar c�digo extens�vel � uma responsabilidade do desenvolvedor maduro, utilizar design duradouro para um software de boa qualidade e manutenibilidade.


**Abstra��o**

Quando aprendemos sobre orienta��o a objetos com certeza ouvimos sobre abstra��o, � ela que permite que este princ�pio funcione. Se um software possui abstra��es bem definidas logo ele estar� aberto para extens�o.


**Na pr�tica**

Vou usar um exemplo bem simples para podermos entender facilmente como funciona.

Observe esta classe:

```csharp
public enum TipoConta 
{ 
    Corrente, 
    Poupanca 
}

public class Debito
{
    public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Poupanca)
            {
                // Valida Anivers�rio da Conta
                // L�gica para Debita da Poupan�a
            }
            if (tipoConta == TipoConta.Corrente)
            {
                // L�gica para Debita da Conta Corrente
            }
        }
}
```

� uma classe de d�bito em conta que valida o tipo da conta para aplicar a regra de neg�cio correta para conta corrente e para conta poupan�a. Agora vamos supor que surgiu um novo tipo de d�bito em conta, p.ex., conta investimento; logo seria necess�rio modificar a classe.


**Qual � o problema de um IF a mais?**

Se modificarmos a classe colocando mais um `IF` de valida��o, al�m de ter que substituirmos esta classe na publica��o da nova vers�o, corremos o risco de introduzir alguns *bugs* em uma classe que j� estava funcionando.

Al�m de ter que testar todos os tipos de d�bito em conta, um *bug* introduzido nesta modifica��o n�o pararia apenas o d�bito em conta investimento, mas poderia causar que todos os tipos de d�bitos parassem de funcionar.

N�o queremos isso, certo? Na verdade queremos ter o m�nimo de trabalho poss�vel e maior garantia de qualidade.


## Como deveria ser?

Vamos para um exemplo de um c�digo usando abstra��o para gerar **extensibilidade**:


```csharp
public abstract class Debito
{
    public abstract void Debitar(int valor);
}

public class DebitoContaCorrente : Debito
{
    public override void Debitar(int valor)
    {
        // L�gica para Debita da Poupan�a
    }
}

public class DebitoContaPoupanca : Debito
{
    public override void Debitar(int valor)
    {
        // L�gica para Debita da Conta Corrente
    }
}

public class DebitoContaInvestimento : Debito
{
    public override void Debitar(int valor)
    {
        // L�gica para Debita da Conta de Investimento
    }
}
```


Veja que possu�mos agora uma **abstra��o** bem definida, onde todas as **extens�es implementam suas pr�prias regras de neg�cio** sem necessidade de modificar uma funcionalidade devido mudan�as ou inclus�o de outra.

O tipo de d�bito em conta de investimento foi implementado sem modificar nada, usando apenas a extens�o. Al�m de tudo o c�digo est� muito mais bonito, entend�vel e f�cil para aplicar cobertura de testes de unidade. Vale mencionar que tamb�m est� de acordo com o primeiro princ�pio do SOLID o [SRP]


## Conclus�o 

Este princ�pio nos atenta para um melhor design, tornando o software mais extens�vel e facilitando sua evolu��o sem afetar a qualidade do que j� est� desenvolvido.

Para o uso do Open Closed Principle � muito comum utilizarmos o [Strategy Pattern]() descrito nos [Padr�es de Projetos da Gangue dos Quatro (Gang of Four - GoF)][GOF], prometo explic�-lo em outro momento, apenas para n�o tornar este exemplo muito complexo.


## Refer�ncias

[The Open Closed Principle](https://docs.google.com/file/d/0BwhCYaYDn8EgN2M5MTkwM2EtNWFkZC00ZTI3LWFjZTUtNTFhZGZiYmUzODc1/edit?hl=en)


[Bertrand Meyer]: <https://en.wikipedia.org/wiki/Bertrand_Meyer>
[SRP]: <https://github.com/alexandredorea/SOLID/tree/master/src/1.%20SRP>
[GOF]: <https://en.wikipedia.org/wiki/Design_Patterns>