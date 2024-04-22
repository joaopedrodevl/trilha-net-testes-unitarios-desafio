namespace exemploTests;
using exemploTdd.Models;

public class CalculadoraTests
{
    private Calculadora _calculadora;

    public CalculadoraTests()
    {
        _calculadora = new Calculadora();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 2, 4)]
    [InlineData(3, 2, 5)]
    public void DeveSomarDoisNumeros(int a, int b, int resultadoEsperado)
    {
        // Act
        var resultado = _calculadora.Somar(a, b);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(2, 2, 0)]
    [InlineData(3, 2, 1)]
    public void DeveSubtrairDoisNumeros(int a, int b, int resultadoEsperado)
    {
        // Act
        var resultado = _calculadora.Subtrair(a, b);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(2, 2, 4)]
    [InlineData(3, 2, 6)]
    public void DeveMultiplicarDoisNumeros(int a, int b, int resultadoEsperado)
    {
        // Act
        var resultado = _calculadora.Multiplicar(a, b);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, 0)]
    [InlineData(2, 2, 1)]
    [InlineData(3, 2, 1)]
    public void DeveDividirDoisNumeros(int a, int b, int resultadoEsperado)
    {
        // Act
        var resultado = _calculadora.Dividir(a, b);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveAdicionarHistorico()
    {
        // Arrange
        var operacao = "Soma de 1 com 2";

        // Act
        _calculadora.AdicionarHistorico(operacao);

        // Assert
        Assert.Contains(operacao, _calculadora.ObterHistorico());
    }

    [Fact]
    public void DeveObterHistorico()
    {
        // Arrange
        _calculadora.AdicionarHistorico("Soma de 1 com 2");
        _calculadora.AdicionarHistorico("Subtração de 2 por 1");
        _calculadora.AdicionarHistorico("Multiplicação de 2 por 2");
        _calculadora.AdicionarHistorico("Divisão de 2 por 2");

        // Act
        var historico = _calculadora.ObterHistorico();

        // Assert
        Assert.Equal(3, historico.Count);
    }
}