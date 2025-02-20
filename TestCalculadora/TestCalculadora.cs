using Calculos;

namespace TestCalculadora
{
    public class TestCalculos
    {
        private Calculadora calculadora;

        [SetUp]
        public void Setup()
        {
            this.calculadora = new Calculadora();
        }

        [Test]
        public void DeveSomarDoisNumerosPositivos()
        {
            Assert.That(calculadora.Soma(2, 2), Is.EqualTo(4));
        }

        [Test]
        public void DeveSomarPositivoComNegativo()
        {
            Assert.That(calculadora.Soma(6, -2), Is.EqualTo(4));
        }

        [Test]
        public void DeveSomarDoisNumerosNegativos()
        {
            Assert.That(calculadora.Soma(-2, -2), Is.EqualTo(-4));
        }

        [Test]
        public void DeveSomarZero()
        {
            Assert.That(calculadora.Soma(0, 4), Is.EqualTo(4));
            Assert.That(calculadora.Soma(4, 0), Is.EqualTo(4));
        }





    }
}