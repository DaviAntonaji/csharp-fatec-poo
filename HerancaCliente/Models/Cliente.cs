using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente.Models
{
    public class Cliente
    {
        protected int codigo;
        protected string nome;
        protected string endereco;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public Cliente()
        {
        }
        public Cliente(int c, string n, string e)
        {
            Codigo = c;
            Nome = n;
            this.Endereco = e;
        }
        public void Mostrar()
        {   
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome+
            "\tEndereço: " + Endereco);
        }
    }
}