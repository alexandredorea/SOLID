# Open Closed Principle – OCP
## Princípio Aberto-Fechado


Este é o segundo princípio do SOLID e certamente o princípio mais polêmico, desconhecido e não utilizado. Descrito por [Bertrand Meyer] em seu livro **Object Oriented Software Construction**, Prentice Hall, 1988, p. 23, diz basicamente o seguinte:

> Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification

Entidades de software (classes, módulos, funções, etc) devem estar abertas para extensão, mas fechadas para modificação. Em outra palavras, você deve ser capaz de estender um comportamento de uma classe, sem modificá-lo.

Softwares são evolutivos, raramente um software é feito uma vez e nunca mais será modificado. 

> *"O Open Closed Principle, afirma que a concepção e escrita do código devem ser feita de uma forma que a nova funcionalidade deve ser adicionada com mudanças mínimas no código existente; que o projeto deve ser feito de forma a permitir a adição de novas funcionalidades como as novas classes, mantendo tanto quanto possível o código existente inalterado."*


## Onde esse princípio tenta chegar?


**Extensibilidade**

É uma das chaves da orientação a objetos, quando **um novo comportamento ou funcionalidade precisar ser adicionado** é esperado que **as existentes sejam estendidas** e **não alteradas**, assim o código original permanece intacto e confiável enquanto as novas são implementadas através de extensibilidade. Criar código extensível é uma responsabilidade do desenvolvedor maduro, utilizar design duradouro para um software de boa qualidade e manutenibilidade.


**Abstração**

Quando aprendemos sobre orientação a objetos com certeza ouvimos sobre abstração, é ela que permite que este princípio funcione. Se um software possui abstrações bem definidas logo ele estará aberto para extensão.


**Na prática**

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
                // Valida Aniversário da Conta
                // Lógica para Debita da Poupança
            }
            if (tipoConta == TipoConta.Corrente)
            {
                // Lógica para Debita da Conta Corrente
            }
        }
}
```

É uma classe de débito em conta que valida o tipo da conta para aplicar a regra de negócio correta para conta corrente e para conta poupança. Agora vamos supor que surgiu um novo tipo de débito em conta, p.ex., conta investimento; logo seria necessário modificar a classe.


**Qual é o problema de um IF a mais?**

Se modificarmos a classe colocando mais um `IF` de validação, além de ter que substituirmos esta classe na publicação da nova versão, corremos o risco de introduzir alguns *bugs* em uma classe que já estava funcionando.

Além de ter que testar todos os tipos de débito em conta, um *bug* introduzido nesta modificação não pararia apenas o débito em conta investimento, mas poderia causar que todos os tipos de débitos parassem de funcionar.

Não queremos isso, certo? Na verdade queremos ter o mínimo de trabalho possível e maior garantia de qualidade.


## Como deveria ser?

Vamos para um exemplo de um código usando **abstração para gerar extensibilidade**:


```csharp
public abstract class Debito
{
    public abstract void Debitar(int valor);
}

public class DebitoContaCorrente : Debito
{
    public override void Debitar(int valor)
    {
        // Lógica para Debita da Poupança
    }
}

public class DebitoContaPoupanca : Debito
{
    public override void Debitar(int valor)
    {
        // Lógica para Debita da Conta Corrente
    }
}

public class DebitoContaInvestimento : Debito
{
    public override void Debitar(int valor)
    {
        // Lógica para Debita da Conta de Investimento
    }
}
```


Veja que possuímos agora uma **abstração** bem definida, onde todas as **extensões implementam suas próprias regras de negócio** sem necessidade de modificar uma funcionalidade devido mudanças ou inclusão de outra.

O tipo de débito em conta de investimento foi implementado sem modificar nada, usando apenas a extensão. Além de tudo o código está muito mais bonito, entendível e fácil para aplicar cobertura de testes de unidade. Vale mencionar que também está de acordo com o primeiro princípio do SOLID o [SRP].


## Conclusão 

Este princípio nos atenta para um melhor design, tornando o software mais extensível e facilitando sua evolução sem afetar a qualidade do que já está desenvolvido.

Para o uso do Open Closed Principle é muito comum utilizarmos o [Strategy Pattern]() descrito no livro [Padrões de Projetos: Soluções Reutilizáveis de Software Orientados a Objetos][GOF], da ["Gang of Four"(GoF)][GOF Projeto], prometo explicá-lo em outro momento, apenas para não tornar este exemplo muito complexo.


## Referências

[OCP: The Open Closed Principle](https://docs.google.com/file/d/0BwhCYaYDn8EgN2M5MTkwM2EtNWFkZC00ZTI3LWFjZTUtNTFhZGZiYmUzODc1/edit?hl=en)


[Bertrand Meyer]: <https://en.wikipedia.org/wiki/Bertrand_Meyer>
[SRP]: <https://github.com/alexandredorea/SOLID/tree/master/src/1.%20SRP>
[GOF]: <https://en.wikipedia.org/wiki/Design_Patterns>
[GOF Projeto]: <https://github.com/alexandredorea/GoF>
