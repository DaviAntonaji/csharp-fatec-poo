// função Main()

using HerancaFuncionario.Models;

Funcionario f = new Funcionario(1, "Ana", 1000);
f.Mostrar();
Console.WriteLine("Bonificação: " + f.CalcularBonificacao());

Secretario s = new Secretario(2, "Bia", 1000);
s.Mostrar();
Console.WriteLine("Bonificação: " + s.CalcularBonificacao());

Gerente g = new Gerente(3, "Leo", 1000);
g.Mostrar();
Console.WriteLine("Bonificação: " + g.CalcularBonificacao());

Diretor d = new Diretor(4, "Teo", 1000);
d.Mostrar();
Console.WriteLine("Bonificação: " + d.CalcularBonificacao());