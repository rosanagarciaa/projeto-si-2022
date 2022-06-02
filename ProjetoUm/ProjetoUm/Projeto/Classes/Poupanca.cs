using System;

namespace Projeto.Classes
{
    public class Poupanca : Conta
    {
        public Poupanca (Clientes cliente, int numero, decimal saldo)
        : base (cliente, numero, saldo)
        { }


        public override bool Sacar (decimal valorSaque)
        {
            if (Saldo <= 0m)
            {
                throw new Exception ($"O valor do saldo é insuficiente para realizar um saque. O valor de seu saldo atual é {Saldo}");
            }

            if (Saldo < valorSaque)
            {
                throw new Exception ($"O valor solicitado para o saque é {valorSaque} e o seu saldo atual é {Saldo}");
            }

            Saldo = Saldo - (valorSaque + 0.1m);
            Console.WriteLine("O saque foi realizado com sucesso.");
            return true;
        }

        public override bool Depositar (decimal valorDeposito)
        {
            if (valorDeposito <=0)
            {
                throw new Exception ($"O valor desse depósito é inválido");
            }

            Saldo += valorDeposito + 0.5m;
            Console.WriteLine ("O depósito foi realizado com sucesso.");
            return true;
        }
    }
}