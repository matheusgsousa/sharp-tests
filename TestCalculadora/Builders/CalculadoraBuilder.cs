using Calculos;

namespace TestCalculadora.Builders
{
    
    public class CalculadoraBuilder
    {
        public Calculadora calculadora;
        public CalculadoraBuilder()
        {
            this.calculadora = new Calculadora();
        }
        public Calculadora Cria() { return calculadora; }
        public CalculadoraBuilder Soma2mais2()
        {
            calculadora.Soma(2, 2);
            return this;
        }
    }
}
