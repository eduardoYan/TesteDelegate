using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDelegate
{
    partial class Homem : pessoa
    {
        private int PeitoralCM { get; set; }

        public Homem(string nome, int idade,int peso, int PeitoralCM, int biceps)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.PeitoralCM = PeitoralCM;
            this.biceps = biceps;
        }
        
    }
}
