using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoArrayConta
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Rg { get; set; }
        //ctor
        public Cliente(string n, int c, int r)
        {   
            Nome = n;
            Cpf = c;
            Rg = r;
        }
    }

}