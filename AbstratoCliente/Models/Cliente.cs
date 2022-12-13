using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente.Models
{
    public abstract class Cliente
    {
        public int Codigo {set; get;}
        public string Nome {set; get;}
        public int Idade {set; get;}

        public Cliente(int c, string n, int i)
        {
            Codigo = c;
            Nome = n;
            Idade = i;
        }
        public virtual void Mostrar(){
            Console.WriteLine("Código: " + Codigo +
                            "\tNome: " + Nome);
        }
        public abstract void VerificaIdade();        
    }
}