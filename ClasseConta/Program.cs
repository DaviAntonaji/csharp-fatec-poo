// Main()
using ClasseConta;
using System;
Conta c1; // declaração de variável
c1 = new Conta();//instanciação de objeto
c1.numero = 1;
c1.titular = "Bia";
c1.saldo = 100;
Conta c2 = new Conta();
Console.Write("Digite o número da conta: ");
c2.numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o titular da conta: ");
c2.titular = Console.ReadLine();
Console.Write("Digite o saldo da conta: ");
c2.saldo = Convert.ToDouble(Console.ReadLine());
c1.MostrarDados();
c2.MostrarDados();
//Calcule e apresente o total de saldo dos correntistas
double somaSaldo = c1.saldo + c2.saldo;
Console.WriteLine("Resultado R$" + somaSaldo);