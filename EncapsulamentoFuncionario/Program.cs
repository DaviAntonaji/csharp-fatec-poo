using EncapsulamentoFuncionario;

namespace EncapsulamentoFuncionario{
    public class Program{
        public static void Main(string[] args){
            /*
            Funcionario f1 = new Funcionario();
            f1.Codigo = 10;//utilizou o set
            Console.WriteLine("Código: " + f1.Codigo); // get
            Console.Write("Cadastre o nome do funcionário: ");
            f1.Nome = Console.ReadLine();//set
            Console.WriteLine("Nome: " + f1.Nome); // get
            Console.Write("Cadastre o salário funcionário: ");
            f1.Salario = Convert.ToDouble(Console.ReadLine());
            if (f1.Salario >= 1000) //get
                Console.WriteLine("Bem remunerado: " + f1.Salario);
            else{
                double novo = f1.Salario + 150; //get
                Console.WriteLine($"Novo: {novo:n}");
                //aumento de 10%
                f1.Salario = f1.Salario + f1.Salario * 10 /100;
                Console.WriteLine($"Novo salário {f1.Salario:c}");
            }*/

            Funcionario f2 = new Funcionario();
            f2.Codigo = 5;
            f2.Salario = 0;
            f2.Nome = "";

        }
    }
}
