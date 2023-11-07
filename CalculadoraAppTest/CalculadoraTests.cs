using System;
using Xunit;
using CalculadoraApp;

namespace CalculadoraAppTest
{
    public class CalculadoraTests
    {
        public Calculadora InstanciarCalculadora()
        {
            return new Calculadora(DateTime.Now);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 4, 8)]
        public void Somar_DoisNumerosInteiros_RetornarSoma(int num1, int num2, int resultadoEsperado)
        {
            Calculadora calc = InstanciarCalculadora();

            int resultado = calc.Somar(num1, num2);

            Assert.Equal(resultadoEsperado, resultado);

        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(5, 3, 2)]
        public void Subtrair_DoisNumerosInteiros_RetornarSubtracao(int num1, int num2, int resultadoEsperado)
        {
            Calculadora calc = InstanciarCalculadora();

            int resultado = calc.Subtrair(num1, num2);

            Assert.Equal(resultadoEsperado, resultado);

        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 4, 16)]
        public void Multiplicar_DoisNumerosInteiros_RetornarMultiplicacao(int num1, int num2, int resultadoEsperado)
        {
            Calculadora calc = InstanciarCalculadora();

            int resultado = calc.Multiplicar(num1, num2);

            Assert.Equal(resultadoEsperado, resultado);

        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(4, 4, 1)]
        public void Dividir_DoisNumerosInteiros_RetornarDivisao(int num1, int num2, int resultadoEsperado)
        {
            Calculadora calc = InstanciarCalculadora();

            int resultado = calc.Dividir(num1, num2);

            Assert.Equal(resultadoEsperado, resultado);

        }

        [Fact]
        public void Dividir_UmNumeroPorZero_RetornarException()
        {
            Calculadora calc = InstanciarCalculadora();
            int num1 = 1;
            int num2 = 0;

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(num1, num2));

        }

        [Fact]
        public void Historico_RetornarHistoricoOperacoes_Retornar3Resultados()
        {
            Calculadora calc = InstanciarCalculadora();
            calc.Somar(1,2);
            calc.Subtrair(2, 1);
            calc.Multiplicar(1, 0);
            calc.Dividir(2, 1);

            var resultado = calc.RetornarHistoricoOperacoes();

            Assert.NotEmpty(resultado);
            Assert.Equal(3, resultado.Count);

        }

    }


}
