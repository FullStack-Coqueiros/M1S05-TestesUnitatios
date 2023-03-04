using Calculadora;

namespace ExemploTeste;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Soma_DoisNumerosInteiros_NumeroInteiro()
    {
        //Arrage
        int num1 = 5;
        int num2 = 2;
        int resultadoEsperado = 7;
        var calculadoraServices = new CalculadoraServices();
        //ACT
        var resultado = calculadoraServices.Soma(num1, num2);
        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }
    [TestMethod]
    public void Subtracao_DoisNumerosInteiros_NumeroInteiro()
    {
        //Arrage
        int num1 = 5;
        int num2 = 2;
        int resultadoEsperado = 3;
        var calculadoraServices = new CalculadoraServices();

        //ACT
        var resultado = calculadoraServices.Subtracao(num1, num2);
        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }
    [TestMethod]
    [DataRow(5,2,10)]
    [DataRow(2,3,6)]
    [DataRow(2, 8, 16)]
    public void Multiplicacao_DoisNumerosInteiros_NumeroInteiro(int num1, int num2, int resultadoEsperado)
    {
        //Arrage
        var calculadoraServices = new CalculadoraServices();
        //ACT
        var resultado = calculadoraServices.Multiplicacao(num1, num2);
        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }


}