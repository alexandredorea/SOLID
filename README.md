# Princípios da Programação Orientação a Objetos: SOLID

## Introdução

SOLID é um acrônimo dos cinco primeiros princípios da programação orientada a objetos e design de código identificados por [Robert C. Martin][Uncle Bob] (ou Uncle Bob) por volta do ano 2000. O acrônimo SOLID foi introduzido por [Michael Feathers], após observar que os cinco princípios poderiam se encaixar nesta palavra.

Lembrando também que além destes 5 princípios Robert C. Martin também mapeou 3 outros princípios sobre **Coesão** e mais outros 3 sobre **Acoplamento**, mas não serão abordados.

## Objetivo

Os padrões SOLID são considerados uma boa prática de programação orientada a objetos que visam diminuir o acoplamento entre classes e separar responsabilidades como forma de melhorar o código da aplicação desenvolvida. Neste sentido, este pequeno projeto apresentará os padrões que compõem o SOLID - ou seja - este pequeno projeto tem a intenção de demonstrar a teoria e a prática, bem como a violação de cada um dos princípios, como utilizar os mesmos para a solução e demonstrar como o SOLID pode lhe proporcionar um melhor design de código facilitando a manutenção e o teste.

Aqui estão uma breve descrição sobre eles:

| Letra      | Sigla        |Nome                                                                                | Definição                                                                        |
|------------|--------------|------------------------------------------------------------------------------------|----------------------------------------------------------------------------------|
| [S][1-SRP] | [SRP][1-SRP] | [*Single Responsibility Principle* (Princípio da Responsabilidade Única)][1-SRP]   | Uma classe deve ter um, e somente um, motivo para ser alterada.                  |
| [O][2-OCP] | [OCP][2-OCP] | [*Open / Closed Principle* (Princípio do Aberto/Fechado)][2-OCP]                   | Você deve ser capaz de estender um comportamento de uma classe, sem modificá-lo. |
| [L][3-LSP] | [LSP][3-LSP] | [*Liskov Substitution Principle* (Princípio da Substituição de Liskov)][3-LSP]     | As classes base devem ser substituíveis por suas classes derivadas.              |
| [I][4-ISP] | [ISP][4-ISP] | [*Interface Segregation Principle* (princípio da segregação de Interfaces)][4-ISP] | Muitas interfaces específicas são melhores do que uma interface única.           |
| [D][5-DIP] | [DIP][5-DIP] | [*Dependency Inversion Principle* (princípio da inversão de dependência)][5-DIP]   | Dependa de uma abstração e não de uma implementação.                             |


## Justificativas

Os princípios SOLID devem ser aplicados para se obter os benefícios da orientação a objetos, tais como:

- Seja fácil de se manter, adaptar e se ajustar às constantes alterações exigidas pelos clientes;
- Seja fácil de entendimento e testar;
- Seja construído de forma a estar preparado para ser facilmente alterado com o menor esforço possível;
- Seja possível de ser reaproveitado;
- Que atenda realmente as necessidades dos clientes para o qual foi criado;


Utilizando os princípios SOLID é possível evitar problemas muito comuns como:

- Dificuldade na testabilidade / criação de testes de unidade;
- Código macarrônico, sem estrutura ou padrão;
- Dificuldades de isolar funcionalidades;
- Duplicação de código, uma alteração precisa ser feita em N pontos;
- Fragilidade, o código quebra facilmente em vários pontos após alguma mudança;
- Erros, Falhas e Defeitos.
  - Falha: resultado ou manifestação de um ou mais defeitos (diferença indesejável entre o observado e o esperado (defeito encontrado));
  - Erro (*error*): indica que certas funcionalidades do software não estão se comportando como especificado (engano cometido por serer humanos);
  - Defeito (*failure*): é a manifestação do erro, seja através de uma tela com uma mensagem para usuário, etc. (resultado de um erro encontrado num código ou num documento).


## Referências

1. [Os Princípios de Design Orientado a Objetos](http://butunclebob.com/ArticleS.UncleBob.PrinciplesOfOod)
2. [Princípios e Padrões de Projetos](http://www.objectmentor.com/resources/articles/Principles_and_Patterns.pdf)
3. [SOLID, Wikipedia](https://en.wikipedia.org/wiki/SOLID)


[Uncle Bob]: <https://en.wikipedia.org/wiki/Robert_C._Martin>
[Michael Feathers]: <https://www.r7krecon.com/michael-feathers-bio>
[1-SRP]: <https://github.com/alexandredorea/SOLID/tree/master/src/1.%20SRP>
[2-OCP]: <https://github.com/alexandredorea/SOLID/tree/master/src/2.%20OCP>
[3-LSP]: <https://github.com/alexandredorea/SOLID>
[4-ISP]: <https://github.com/alexandredorea/SOLID>
[5-DIP]: <https://github.com/alexandredorea/SOLID>