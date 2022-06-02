using System;
using System.Collections.Generic;
using Projeto.Classes;

namespace Projeto
{
    class Program
    {
        static void Main()
        {
            try
            {
                #region  |Clientes|
                Console.WriteLine("Digite o nome do cliente: ");
                string nomeCliente = Console.ReadLine();
                Console.WriteLine("Digite o endereço do cliente: ");
                string enderecoCliente = Console.ReadLine();
                Console.WriteLine("Digite o telefone do cliente: ");
                string telefone = Console.ReadLine();
                long telefoneCliente = long.Parse(telefone);
                Console.WriteLine("Digite o CPF do cliente: ");
                string cpfCliente = Console.ReadLine();
                Console.WriteLine("Digite a data de nascimento do cliente: ");  
                string dataNascimento = Console.ReadLine();
                DateTime dataNascimentoCliente = DateTime.Parse(dataNascimento);

                var cliente1= Clientes.CreateCliente(nomeCliente, enderecoCliente, telefoneCliente, cpfCliente, dataNascimentoCliente);
                Console.WriteLine(cliente1.ToString());

                var cliente2 = Clientes.CreateCliente ("Cliente 2", "Endereço Cliente 2", 16999999999, "399.999.999-99", new DateTime(2000,01,01));
                Console.WriteLine(cliente2.ToString());
                #endregion

                #region  |Conta poupança|
                Conta contaPoupancaCliente = new Poupanca (cliente1, 123456, 1000);
                Console.WriteLine($"O saldo é: R$: {contaPoupancaCliente.Saldo}.");

                Console.WriteLine("Qual o valor do depósito que deseja realizar?");
                int valorDepo1 = int.Parse (Console.ReadLine());
                contaPoupancaCliente.Depositar(valorDepo1);
                Console.WriteLine($"O saldo atual é: R$ {contaPoupancaCliente.Saldo}");

                Console.WriteLine("Qual valor deseja sacar?");
                int valorSaque1 = int.Parse(Console.ReadLine());
                contaPoupancaCliente.Sacar(valorSaque1);
                Console.WriteLine($"O saldo atual é: R$ {contaPoupancaCliente.Saldo}");
                #endregion

                #region  |Conta corrente|
                Conta contaCorrenteCliente = new ContaCorrente (cliente2, 987654, 1000);
                Console.WriteLine($"O saldo é: R$ {contaCorrenteCliente.Saldo}");

                Console.WriteLine("Qual o valor do depósito que deseja realizar?");
                int valorDepo2 = int.Parse(Console.ReadLine());
                contaCorrenteCliente.Depositar(valorDepo2);
                Console.WriteLine($"O saldo atual é: R$ {contaCorrenteCliente.Saldo}");
                Console.WriteLine("Qual valor deseja sacar?");
                int valorSaque2 = int.Parse(Console.ReadLine());
                contaCorrenteCliente.Sacar(valorSaque2);
                Console.WriteLine($"O saldo atual é: R$ {contaCorrenteCliente.Saldo}");

                List<Conta> contas = new List<Conta>() { contaPoupancaCliente, contaCorrenteCliente };
                #endregion

                #region  |Transferência|
                Console.WriteLine("Qual o valor que deseja transferir?");
                int valorTransferencia = int.Parse(Console.ReadLine());
                contaPoupancaCliente.Transferir(valorTransferencia, contaCorrenteCliente);
                Console.WriteLine($"O saldo atual é: {contaPoupancaCliente.Saldo}");
                Console.WriteLine($"O saldo atual é: {contaCorrenteCliente.Saldo}");
                #endregion
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
