// função Main()
using HerancaCliente.Models;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Ana";
c.Endereco = "Rua Terezina, 75";

ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Bia";
cf.Endereco = "Rua Terezina, 100";
cf.Rg = 100;
cf.Cpf = 1000;

ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 3;
cj.Nome = "Chuchu e Cia";
cj.Endereco = "Rua Terezina, 200";
cj.Cnpj = 30;
cj.Ie = 300;

Cliente c2 = new Cliente(4,"Leo","Rua três");
c2.Mostrar();
ClienteFisico cf2 = new ClienteFisico(5, "Lia", "Rua quatro",55, 555);
cf2.Mostrar();
ClienteJuridico cj2 = new ClienteJuridico(6, "Bolo e Cia", "Rua Limão", 60,600);
cj2.Mostrar();


