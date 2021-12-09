using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDelegate
{
    abstract class pessoa : iPessoaAcoes
    {
        public string nome { get; set; }
        public int peso { get; set; }
        public int idade { get; set; }

        public  bool conferirMensalidade(int dias)
        {
            if (dias > 30)
            {
                Console.WriteLine("Mensalidade Atrasada");
                return false;
            }
            else
            {
                return true;
            }
        }
        public void aumentarpeso(int peso)
        {
            this.peso = this.peso + peso;
        }
    }
}
