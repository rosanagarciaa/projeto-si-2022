using System;

namespace Projeto.Classes
{
  public abstract class Conta
    {
        public Conta (Clientes cliente, int numero, decimal saldo) 
        {  if (!cliente.IdadeCliente)
                throw new Exception("O cliente tem menos de 18 anos, assim não pode abrir uma conta.");

            if (numero.ToString ().Length < 5)
                throw new Exception("A conta apresenta menos de 5 dígitos, portanto é inválida.");

            Cliente = cliente;
            Numero = numero;
            Saldo = saldo;
        }

        public decimal _saldo;
        public int Numero { get; private set; }
        public Clientes Cliente { get; private set; }
        public string Mensagem { get; set; }

        public decimal Saldo
        {
            get { return _saldo; } 
            protected set
            {
                if (value >= 0)
                    _saldo = value;
                else
                    _saldo = 0;
            }
        }
        public abstract bool Sacar (decimal valorSaque);

        public abstract bool Depositar (decimal valorDeposito);

        public void Transferir (decimal valorSacar, Conta destino)
        {
            var sucessoTransacaoSaque = Sacar(valorSacar);
            var sucessoTransacaoDepo = destino.Depositar(valorSacar);

            if (sucessoTransacaoSaque && sucessoTransacaoDepo)
            {
               throw new Exception ("Transferência realizada com sucesso!");
            }

            Console.WriteLine("Falha na operação.");
        }
    }
}
