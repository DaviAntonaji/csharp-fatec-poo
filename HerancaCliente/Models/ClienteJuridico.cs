using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente.Models
{
    public class ClienteJuridico : Cliente
    {
        private int cnpj;
        private int ie;
        public int Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        
        public int Ie
        {
            get { return ie; }
            set { ie = value; }
        }
        public ClienteJuridico()
        {
            
        }
         public ClienteJuridico(int c, string n, string e, int cn, int ie)
                            : base(c, n, e)
        {
            Cnpj = cn;
            Ie = ie;
        }
        public void Mostrar()
        {   
            base.Mostrar();
            Console.WriteLine("Cnpj: " + Cnpj + "\tIe: " + Ie);
        }
    }
}