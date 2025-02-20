using Lojinha;
using Moq;

namespace TestMaiorMenor
{
    [TestFixture]
    public class TestMaiorEMenor
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OrdemDecrescente()
        {
            var carrinhoMock = new Mock<CarrinhoDeCompras>();
            var carrinho = carrinhoMock.Object;
            carrinho.Produtos = new List<Produto>();
             
            carrinho.Adicionar(new Produto("Geladeira", 450.0));
            carrinho.Adicionar(new Produto("Liquidificador", 250.0));
            carrinho.Adicionar(new Produto("Jogo de pratos", 70.0));
            
            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.That(algoritmo.Menor.Nome, Is.EqualTo("Jogo de pratos"));
            Assert.That(algoritmo.Maior.Nome, Is.EqualTo("Geladeira"));

        }
        [Test]
        public void ApenasUmProduto()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Produtos = new List<Produto>();
            carrinho.Adicionar(new Produto("Geladeira", 450.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Geladeira", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);

        }
    }
}