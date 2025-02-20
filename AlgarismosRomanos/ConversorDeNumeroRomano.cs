namespace AlgarismosRomanos
{
    public class ConversorDeNumeroRomano
    {
        private static Dictionary<char, int> tabela =
            new Dictionary<char, int>() {
                 {'I', 1}, 
                 {'V', 5},
                 {'X', 10},
                 {'L', 50},
                 {'C', 100},
                 {'D', 500},
                 {'M', 1000}
        };


        public int Converte(String numeroEmRomano)
        {
            int acumulador = 0;
            int ultimoVizinhoDaDireita = 0;
            for (int i = numeroEmRomano.Length - 1; i >= 0; i--)
            {
                int atual = tabela[numeroEmRomano[i]];

                int multiplicador = 1;
                if (atual < ultimoVizinhoDaDireita) 
                    multiplicador = -1;

                acumulador += atual * multiplicador;

                ultimoVizinhoDaDireita = atual;
            }
            return acumulador;
        }
    }
}

/*
    Os números eram representados por sete diferentes símbolos, listados
 na tabela a seguir.
     • I, unus, 1, (um)
     • V, quinque, 5 (cinco)
     • X,decem, 10 (dez)
     • L, quinquaginta, 50 (cinquenta)
     • C,centum, 100 (cem)
     • D,quingenti, 500 (quinhentos)
     • M,mille, 1.000 (mil)
    Para representar outros números, os romanos combinavam estes símbolos, co
meçando do algarismo de maior valor e seguindo a regra:
    • Algarismos de menor ou igual valor à direita são somados ao algarismo de
    maior valor;
    • Algarismos de menor valor à esquerda são subtraídos do algarismo de maior
    valor.
    Por exemplo, XV representa 15(10+5)e o número XXVIII representa 28(10+10
    + 5+1+1+1). Há ainda uma outra regra: nenhum símbolo pode ser repetido lado
    a lado por mais de3vezes. Por exemplo, o número4 é representado pelo número IV
    (5- 1) e não pelo número IIII.

*/
