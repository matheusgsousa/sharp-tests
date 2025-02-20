using Moq;
using NotaFiscalLib;

namespace TestNotaFiscal
{
    public class TestNotaFiscal
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void DeveGerarNFComValorDeImpostoDescontado()
        {
            var dao = new Mock<NFDao>();

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object);
            Pedido pedido = new Pedido("Matheus", 1000, 1);
            NotaFiscal nf = gerador.Gera(pedido);
            Assert.That(nf.Valor, Is.EqualTo(1000 * 0.94).Within(0.0001));
        }

        [Test]
        public void DevePersistirNFGerada()
        {


            var dao = new Mock<NFDao>();

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object);
            Pedido pedido = new Pedido("Mauricio", 1000, 1);
            NotaFiscal nf = gerador.Gera(pedido);

            dao.Verify(t => t.Persiste(nf));
        }
    }
}