using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoDepartmento.Models
{
    public class Comissionado : Funcionario
    {
        public double Porcentagem { get; set; }
        public Comissionado(int c, string n, double s, double p)
                            : base (c, n, s)
        {
            Porcentagem = p;
        }
        public override double CalcularSalario(int diasUteis)
        {
            return Salario / 30 * diasUteis * Porcentagem + Salario;
        }
        public override void MostrarDados()
        {
            base.MostrarDados();//mostra codigo, nome, e salário
            Console.WriteLine("Porcentagem: "+Porcentagem);
        }
    }
}