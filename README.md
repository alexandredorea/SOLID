# Princípios de Orientação a Objetos: SOLID

## Introdução

SOLID é um acrônimo dos cinco primeiros princípios da programação orientada a objetos e design de código identificados por [Robert C. Martin](https://en.wikipedia.org/wiki/Robert_C._Martin) (ou Uncle Bob) por volta do ano 2000. O acrônimo SOLID foi introduzido por [Michael Feathers](https://www.r7krecon.com/michael-feathers-bio), após observar que os cinco princípios poderiam se encaixar nesta palavra.

Lembrando também que além destes 5 princípios Robert C. Martin também mapeou 3 outros princípios sobre **Coesão** e mais outros 3 sobre **Acoplamento**. 

## Objetivo

Os padrões SOLID são considerados uma boa prática de programação orientada a objetos que visam diminuir o acoplamento entre classes e separar responsabilidades como forma de melhorar o código da aplicação desenvolvida. Neste sentido, este pequeno projeto apresentará os padrões que compõem o SOLID - ou seja - este pequeno projeto tem a intenção de demonstrar a teoria e a prática, bem como a violação de cada um dos princípios, como utilizar os mesmos para a solução e demonstrar como o SOLID pode lhe proporcionar um melhor design de código facilitando a manutenção e o teste.

Aqui estão uma breve descrição sobre eles:

|Letra |Sigla |Nome                                                                       | Definição                                                                        |
|------|------|---------------------------------------------------------------------------|----------------------------------------------------------------------------------|
| S    | SRP  | *Single Responsibility Principle* (Princípio da Responsabilidade Única)   | Uma classe deve ter um, e somente um, motivo para mudar.                         |
| O    | OCP  | *Open / Closed Principle* (Princípio do Aberto/Fechado)                   | Você deve ser capaz de estender um comportamento de uma classe, sem modificá-lo. |
| L    | LSP  | *Liskov Substitution Principle* (Princípio da Substituição de Liskov)     | As classes base devem ser substituíveis por suas classes derivadas.              |
| I    | ISP  | *Interface Segregation Principle* (princípio da segregação de Interfaces) | Muitas interfaces específicas são melhores do que uma interface única.           |
| D    | DIP  | *Dependency Inversion Principle* (princípio da inversão de dependência)   | Dependa de uma abstração e não de uma implementação.                             |

## Justificativas

Os princípios SOLID devem ser aplicados para se obter os benefícios da orientação a objetos, tais como:

* Seja fácil de se manter, adaptar e se ajustar às alterações de escopo;
* Seja testável e de fácil entendimento;
* Seja extensível para alterações com o menor esforço necessário;
* Que forneça o máximo de reaproveitamento;
* Que permaneça o máximo de tempo possível em utilização.


Utilizando os princípios SOLID é possível evitar problemas muito comuns:

* Dificuldade na testabilidade / criação de testes de unidade;
* Código macarrônico, sem estrutura ou padrão;
* Dificuldades de isolar funcionalidades;
* Duplicação de código, uma alteração precisa ser feita em N pontos;
* Fragilidade, o código quebra facilmente em vários pontos após alguma mudança.


## Referências:
1. [Os Princípios de Design Orientado a Objetos](http://butunclebob.com/ArticleS.UncleBob.PrinciplesOfOod)
2. [Princípios e Padrões de Projetos](http://www.objectmentor.com/resources/articles/Principles_and_Patterns.pdf)
3. [SOLID, Wikipedia](https://en.wikipedia.org/wiki/SOLID)
