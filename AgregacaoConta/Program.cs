// função Main()
using AgregacaoConta;

Cliente cli = new Cliente();
cli.Nome = "Ana";
cli.Cpf = 123;
cli.Rg = 11;

Conta c1 = new Conta();
c1.Numero = 1;
c1.Saldo = 100;
c1.Titular = cli;
Console.WriteLine("Nome: " + c1.Titular.Nome);

Conta c2 = new Conta();
c2.Numero = 2;
c2.Saldo = 200;
c2.Titular = new Cliente();
c2.Titular.Nome = "Bia";
c2.Titular.Cpf = 2234;
c2.Titular.Rg = 22;
Console.WriteLine("Nome: " + c2.Titular.Nome);

