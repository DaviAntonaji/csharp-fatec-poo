// Função Main()
using ArrayFuncionario;
Console.WriteLine("...........EXEMPLO COM VETOR ...........");
/*
Funcionario f1 = new Funcionario();
Funcionario f2 = new Funcionario();
Funcionario f3 = new Funcionario();
Funcionario f4 = new Funcionario(); 
É inviável trabalhar instancionado diversos objetos
solução, usar vetor*/
Funcionario[] vetF = new Funcionario[3];
for (int i = 0; i < vetF.Length; i ++){
    //instancia cada índice do vetor
    vetF[i] = new Funcionario();
    Console.Write("Informe o código: ");
    vetF[i].codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Informe o nome: ");
    vetF[i].nome = Console.ReadLine();
    Console.Write("Informe o salário: ");
    vetF[i].salario = Convert.ToDouble(Console.ReadLine());
}
for (int i = 0; i < vetF.Length; i ++)
    vetF[i].MostrarAtributos();



