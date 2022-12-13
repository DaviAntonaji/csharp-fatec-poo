using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoArrayConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public List<Cliente> VetTitular { get; set; }        
    }
}