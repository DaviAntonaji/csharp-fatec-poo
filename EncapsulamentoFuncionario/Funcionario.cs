using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        //declaração dos atributos
        private int codigo;
        private string nome;
        private double salario;
        //encapsulamento
        //declaração dos métodos get e set
        /*public int Codigo //propriedade
        {
            get { return codigo; }
            set { codigo = value; }
        } */
        public int Codigo //propriedade
        {
            get => codigo; // get
            set => codigo = value; // set
        } 
        public string Nome //propriedade
        {
            get { return nome.ToUpper(); }
            set 
            { 
                if (value != "")
                    nome = value; 
                else
                    Console.WriteLine("Nome deve ter conteúdo");
            }
        }  
        public void MostrarAtributos(){
            Console.WriteLine("Código: " + codigo + 
                            "\tNome: " + nome +
                            "\tSalário: " + salario);
        }  
         
        public double Salario
        {
            get { return salario; }
            set 
            { 
                if (value > 0)
                    salario = value;
                else
                    Console.WriteLine("Salário inválido");
            }
        }
              
    }
}