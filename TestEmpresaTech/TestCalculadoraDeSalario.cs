using EmpresaTech;

namespace TestEmpresaTech
{
    [TestFixture]
    public class TestCalculadoraDeSalario
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Matheus", 1500,  Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.That(salario, Is.EqualTo(1500.0 * 0.85).Within(0.00001));

        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Matheus", 4000.0, Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);
            Assert.That(salario, Is.EqualTo(4000.0 * 0.8).Within(0.00001));
        }

        [Test]
        public void DeveCalcularSalarioParaDBAsComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario dba = new Funcionario("Matheus", 500.0, Cargo.DBA);

            double salario = calculadora.CalculaSalario(dba);
            Assert.That(salario, Is.EqualTo(500 * 0.85).Within(0.00001));
        }

    }
}