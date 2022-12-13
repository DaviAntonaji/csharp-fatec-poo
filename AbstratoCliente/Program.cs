using System;
using AbstratoCliente.Models;

namespace AbstratoCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            //não pode ser instanciado um objeto de uma classe abstract
            //Cliente c = new Cliente();

            ClienteFisico cf = new ClienteFisico(1, "Ana",20,10);
            cf.Mostrar();
            ClienteJuridico cj = new ClienteJuridico(2, "Bia S/A",60,10);
            cj.Mostrar();

            Teste t = new Teste();
            t.VerificaIdadeClasses(cf);

            Teste t2 = new Teste();
            t2.VerificaIdadeClasses(cj);
        }
    }
}
