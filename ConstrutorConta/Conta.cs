using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }//propriedade
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public static int Contador { get; private set; }
        
        static Conta(){//construtor static
            Contador = 30;
        }
        public Conta(){//método construtor
            Contador = Contador + 1;
        }
        public Conta(int numero){
            this.Numero = numero;
            Contador = Contador + 1;
        }
        public Conta(int numero, string titular){
            this.Numero = numero;
            this.Titular = titular;
            Contador = Contador + 1;
        }
        public Conta(int numero, string titular, double saldo){
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
            Contador = Contador + 1;
        }
        public void MostrarDados(){
            Console.WriteLine("Número: " + Numero +
                        "\tTitular: " + Titular +
                        "\tSaldo: " + Saldo);
        }
    }
}