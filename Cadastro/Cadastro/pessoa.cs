using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    internal class pessoa
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public string login { get; set; }

        public string senha { get; set; }
        public DateTime UltimoAcesso { get; set; }
        public int QtdErroLogin { get; set; }
        public bool Bloqueado { get; set; }

    }
}
