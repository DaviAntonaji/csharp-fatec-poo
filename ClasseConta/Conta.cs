using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta //pasta-projeto
{
    public class Conta
    {
        // declaração de atributos
        public int numero;
        public string titular;
        public double saldo;
        //declaração de métodos
        public void Sacar(){

        }
        public void Depositar(){
            
        }
        public void MostrarDados(){
            Console.WriteLine("Número: " + numero +
                  "\tTitular: " + titular +
                  "\tSaldo: " + saldo);
        }
    }
}