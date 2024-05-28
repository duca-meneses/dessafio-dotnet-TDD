namespace DesafioTDD.Tests;

public class CalculadoraTestes
{
    public Calculadora ContruirClasse() 
    {
        string data = "28/05/2024";
        Calculadora calc = new Calculadora(data);
        return calc;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomarDoisValoresInteirosERetornaOValorCorretoDaOperacao(int num1, int num2, int resultado)
    {
        Calculadora calculadora = ContruirClasse();

        int resultadoCalculadora = calculadora.Somar(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicarDoisValoresInteirosERetornaOValorCorretoDaOperacao(int num1, int num2, int resultado)
    {
        Calculadora calculadora = ContruirClasse();

        int resultadoCalculadora = calculadora.Mutiplicar(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(10, 5, 2)]
    public void TesteDvidirDoisValoresInteirosERetornaOValorCorretoDaOperacao(int num1, int num2, int resultado)
    {
        Calculadora calculadora = ContruirClasse();

        int resultadoCalculadora = calculadora.Dividir(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 4)]
    [InlineData(10, 5, 5)]
    public void TesteSubtrairDoisValoresInteirosERetornaOValorCorretoDaOperacao(int num1, int num2, int resultado)
    {
        Calculadora calculadora = ContruirClasse();

        int resultadoCalculadora = calculadora.Subtrair(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDvisaoPorZero()
    {
        Calculadora calc = ContruirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3, 0)
        );
    }
    
    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = ContruirClasse();

        calc.Somar(1,2);
        calc.Mutiplicar(1,2);
        calc.Somar(4,2);
        calc.Somar(10,2);

        var lista = calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}