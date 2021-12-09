using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDelegate
{
    partial class Homem : pessoa
    {
        private int biceps { get; set; }

        public int ImprimeBiceps()
        {
            return biceps;
        }
    }
}
