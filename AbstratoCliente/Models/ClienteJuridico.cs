using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente.Models
{
    public class ClienteJuridico : Cliente
    {
        public int Cnpj { get; set; }

        public override void Mostrar(){
            base.Mostrar();
            Console.WriteLine("Cnpj: "+ Cnpj);
        }
        public ClienteJuridico(int c, string n, int i, int cn) 
                            : base(c, n, i) 
        {
            Cnpj = cn;
        }
        public override void VerificaIdade()
        {
            if (Idade >= 50)
                Console.WriteLine("Cliente Jurídico"); 
        }
    }    
}