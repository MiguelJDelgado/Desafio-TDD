using NewTalents;

namespace TestNewTalents
{
    public class UnitTest1
    {
        public Calculadora ConstruirClasse()
        {
            DateTime data = DateTime.Now;
            Calculadora calc = new Calculadora(data);
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        [InlineData(5, 7, 12)]
        [InlineData(8, 3, 11)]
        public void TesteSomar(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);    

        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(6, 5, 1)]
        [InlineData(10, 7, 3)]
        [InlineData(8, 3, 5)]
        public void TesteSubtrair(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        [InlineData(5, 7, 35)]
        [InlineData(8, 3, 24)]
        public void TesteMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(10, 5, 2)]
        [InlineData(72, 8, 9)]
        [InlineData(50, 10, 5)]
        public void TesteDividr(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Fact]
        public void TesteDividirpor0()
        {
            Calculadora calc = ConstruirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }

        [Fact]
        public void TesteVerHistorico()
        {
            Calculadora calc = ConstruirClasse();

            calc.somar(3, 1);
            calc.subtrair(3, 1);
            calc.multiplicar(3, 1);
            calc.dividir(3, 1);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count); 
        }

    }
}