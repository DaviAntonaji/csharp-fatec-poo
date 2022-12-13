// função Main()
//public static void Main(string[] args)

using ConstrutorConta;

Conta c1 = new Conta();//construtor padrão
c1.MostrarDados();

Conta c2 = new Conta(10);// segundo construtor
c2.MostrarDados();

Conta c3 = new Conta(11, "Ana");// terceiro construtor
c3.MostrarDados();

Conta c4 = new Conta(13, "Bia", 100);//quarto construtor
c4.MostrarDados();

System.Console.WriteLine("Quantidade de instâncias: "
                        + Conta.Contador);
//Conta.Contador = 9;
/*
System.Console.WriteLine("Quantidade de instâncias: "
                        + c2.Contador);
System.Console.WriteLine("Quantidade de instâncias: "
                        + c3.Contador);
System.Console.WriteLine("Quantidade de instâncias: "
                        + c4.Contador);*/
