using NewTalents.Services;

namespace CalculadoraTest;

public class CalculadoraTest
{
     public CalculadoraImp _calc = new ();

    [Theory]
    [InlineData (3,5,8)]
    [InlineData (4,5,9)]
    [InlineData (5,5,10)]
    public void TestSomar( int val1, int val2, int resultado)
    {
        var resultadoCalc = _calc.Somar(val1, val2);

        Assert.Equal(resultado, resultadoCalc);

    }

    [Theory]
    [InlineData (5,3,2)]
    [InlineData (4,5,-1)]
    [InlineData (5,5,0)]
    public void TestSubtrair( int val1, int val2, int resultado)
    {
        var resultadoCalc = _calc.Subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalc);

    }

    [Theory]
    [InlineData (3,5,15)]
    [InlineData (4,5,20)]
    [InlineData (5,5,25)]
    public void TestMultiplicar( int val1, int val2, int resultado)
    {
        var resultadoCalc = _calc.Multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalc);

    }

    [Theory]
    [InlineData (15,5,3)]
    [InlineData (20,5,4)]
    [InlineData (30,5,6)]
    public void TestDividir( int val1, int val2, int resultado)
    {
        var resultadoCalc = _calc.Dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalc);

    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Assert.Throws<DivideByZeroException>(
            () => _calc.Dividir(3, 0)
        );
    }
    [Fact]
    public void TestarHistorico()
    {
        _calc.Somar(3,5);
        _calc.Dividir(4,6);
        _calc.Multiplicar(4,7);

        var lista = _calc.HistoricoCalc();
        Assert.Equal(3, lista.Count);
        Assert.NotEmpty(lista);
    }
}