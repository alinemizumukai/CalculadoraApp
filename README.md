# DIO - Trilha .NET - TDD e Testes Unitários


## Descrição do projeto
O desafio consiste em implementar testes unitários aplicando a técnica TDD - Test Driven Development.

O sistema possui dois projetos: um do tipo console, e um do tipo testes com **xUnit**.

O projeto do tipo console possui uma classe **Calculadora** que contém os métodos usados para realizar os cálculos de soma, subtração, multiplicação e divisão, além de um método que registra o histórico das três últimas operações.

O projeto de testes possui a classe de teste **CalculadoraTests**, assim como seus métodos para validar o projeto do tipo console.

Inicialmente foram aplicadas as regras de negócio na implementação dos testes, enquanto que a classe do projeto console retornavam apenas o valor default dos tipos de retornos esperados. Após a escrita e execução dos testes, os métodos da classe **Calculadora** foram implementados. Com os testes aprovados, foi realizada uma refatoração do código antes da conclusão.
