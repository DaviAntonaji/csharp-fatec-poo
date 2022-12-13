// função Main()
using AgregacaoArrayConta;
Cliente cli1 = new Cliente("Ana",123,11);
Cliente cli2 = new Cliente("Bia",234,22);

Conta c1 = new Conta();
c1.Numero = 1;
c1.Saldo = 10000;
c1.VetTitular = new List<Cliente>();
c1.VetTitular.Add(cli1);
c1.VetTitular.Add(cli2);
foreach (Cliente cli in c1.VetTitular)
    Console.WriteLine("Nome: " + cli.Nome);

