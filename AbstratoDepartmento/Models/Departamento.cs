using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoDepartmento.Models
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int c, string d)
        {
            Codigo = c;
            Descricao = d;
        }

        public void AdmitirFuncionario(Funcionario f){
            VetF.Add(f);
        }

        public void ListarFuncionarios()
        {
            Console.WriteLine("\nListagem de funcionários......................");
            foreach (Funcionario f in VetF)
                f.MostrarDados();
        }

        public double CalcularFolhaPagamento(int diasUteis)
        {
            double folha = 0;
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha = folha + f.CalcularSalario(diasUteis);
            }
            return folha;
        }
        public void DemitirFuncionario(int codigo)
        {
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == codigo)
                    VetF.Remove(f);
            }
        }
    }
}