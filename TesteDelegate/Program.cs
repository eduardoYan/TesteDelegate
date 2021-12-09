using System;

namespace TesteDelegate
{
    class Program
    {
  
        static void Main(string[] args)
        {
            Homem h1 = new Homem("Joaozinho", 27, 69, 47, 30);
            Func<int, bool> FuncaoDelegada = h1.conferirMensalidade;
            Console.WriteLine(FuncaoDelegada(37));
            Console.WriteLine(h1.ImprimeBiceps());
            Mulher m1 = new Mulher("Mariazinha", 19, 52, 85);
            Action<int> OutraFuncao = m1.aumentarpeso;
            OutraFuncao(7);
            Console.WriteLine("o peso da mulher esta em " + m1.peso);
        }
        
    }
}
