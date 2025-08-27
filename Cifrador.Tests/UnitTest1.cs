namespace Cifrador.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("hola", "hopolapa")]
    [InlineData("papa", "papapapa")]
    [InlineData("xyz", "xyz")]
    public void Encriptar_VariasEntradas_DeberiaRetornarCorrecto(string texto, string esperado)
    {
        string resultado = Jeringozo.Encriptar(texto);
        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData("hopolapa", "hola")]
    [InlineData("papapapa", "papa")]
    [InlineData("xyz", "xyz")]

    public void Desencriptar_VariasEntradas_DeberiaRetornarCorrecto(string texto, string esperado)
    {
        string resultado = Jeringozo.Desencriptar(texto);
        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void Encriptar_ConMayusculas_DeberiaMantenerMayusculas()
    {
        string resultado = Jeringozo.Encriptar("Hola");
        Assert.Equal("Hopolapa", resultado);
    }

    [Fact]
    public void Desencriptar_ConMayusculas_DeberiaMantenerMayusculas()
    {
        string resultado = Jeringozo.Desencriptar("Papapapa");
        Assert.Equal("Papa", resultado);
    }

    [Fact]
    public void Encriptar_ConAcentos_DeberiaDejarAcentosIgual()
    {
        string resultado = Jeringozo.Encriptar("¿Hola como estas?");
        Assert.Equal("¿Hopolapa copomopo epestapas?", resultado);
    }

    [Fact]
    public void Desencriptar_ConAcentos_DeberiaDejarAcentosIgual()
    {
        string resultado = Jeringozo.Desencriptar("¿Hopolapa copomopo epestapas?");
        Assert.Equal("¿Hola como estas?", resultado);
    }
}
