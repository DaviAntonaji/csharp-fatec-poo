using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente.Models
{
    public class ClienteFisico : Cliente
    {
        public int Rg { get; set; }

        public override void Mostrar(){
            base.Mostrar();
            Console.WriteLine("Rg: "+ Rg);
        }
        public ClienteFisico(int c, string n, int i, int r) 
                            : base(c, n, i) 
        {
            Rg = r;
        }
        public override void VerificaIdade()
        {
            if (Idade >= 18 && Idade < 50)
                Console.WriteLine("Cliente Físico"); 
        }
    }    
}