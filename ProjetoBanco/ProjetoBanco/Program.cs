using System;
using ProjetoBanco.Classes;

namespace ProjetoBanco
{
    class program
    {
        static void Main()
        {

            try
            {
                var Rosana = Cliente.CreateCliente("Rosana", "Rua São Bento 1236", 169885963298, "698.655.123-78", new DateTime(2000, 02, 17));
                var Nadia = Cliente.CreateCliente("Nadia", "Rua 9 de Julho 456", 16999856325, "963.987.456-12", new DateTime(2002, 05, 25));

                Console.WriteLine(Rosana.ToString());

                
                Conta contaPoupanca = new Poupanca(Rosana, 458332, 1000);
                Conta contaCorrente = new ContaCorrente(Nadia, 654965, 0);

                contaPoupanca.Transferir(500, contaCorrente);

                Console.WriteLine(contaPoupanca.Saldo);
                contaPoupanca.Depositar(1000);
                Console.WriteLine(contaPoupanca.Saldo);
                contaPoupanca.Sacar(500);
                Console.WriteLine(contaPoupanca.Saldo);

                Console.WriteLine(contaCorrente.Saldo);
                contaCorrente.Depositar(5500);
                Console.WriteLine(contaCorrente.Saldo);
                contaCorrente.Sacar(500);
                Console.WriteLine(contaCorrente.Saldo);


            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
