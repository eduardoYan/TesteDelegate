using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDelegate
{
    class Mulher : pessoa
    {
        private int coxaCM { get; set; }
        public Mulher(string nome, int idade, int peso, int coxaCM)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.coxaCM = coxaCM;
        }

    }
}
