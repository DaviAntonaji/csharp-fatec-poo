using ClasseFuncionario;
// Função Main()
//instanciação de objeto
Funcionario f1 = new Funcionario();
Console.Write("Cadastre o código do funionário: ");
f1.codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("Cadastre o nome do funionário: ");
f1.nome = Console.ReadLine();
Console.Write("Cadastre o salário do funionário: ");
f1.salario = Convert.ToDouble(Console.ReadLine());
f1.MostrarAtributos();
Funcionario f2 = new Funcionario();
f2.MostrarAtributos();