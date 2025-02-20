using LojaVirtual;
using TestLojaVirtual.Builders;

namespace TestLojaVirtual
{
    [TestFixture]
    public class CarrinhoDeComprasTest
    {
        private CarrinhoDeComprasBuilder carrinhoBuilder;
        [SetUp]
        public void Setup()
        {
            this.carrinhoBuilder = new CarrinhoDeComprasBuilder();
        }

        [Test]
        public void DeveRetornarZeroSeCarrinhoVazio()
        {
            var carrinho = carrinhoBuilder.Cria();
            Assert.That(carrinho.MaiorValor(), Is.EqualTo(0).Within(0.0001));
        }
        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            var carrinho = carrinhoBuilder.Cria();
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));

            Assert.That(carrinho.MaiorValor(), Is.EqualTo(900.0).Within(0.0001));
        }

        [Test]
        public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
        {
            var carrinho = carrinhoBuilder.Cria();
            var carrinhoComItens = carrinhoBuilder.ComItens(new double[] { 900.0, 1500.0 }).Cria();
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));
            carrinho.Adiciona(new Item("Fogão", 1, 1500.0));
            carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0));

            Assert.That(carrinho.MaiorValor(), Is.EqualTo(1500));

        }
    }
}