using System;

namespace ProjetoBanco.Classes
{
    public class Cliente
    {
        private Cliente()
        { }

        public string Nome { get; private set; }

        public string Endereco { get; private set; }

        public long Telefone { get; private set; }

        public string CPF { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public bool EMaiordeIdade => ValidarSerClienteEMaiorDeIdade(); 

        public static Cliente CreateCliente(string nome, string endereco, long telefone, string cpf, DateTime datanascimento) =>
            new Cliente { Nome = nome, Endereco = endereco, Telefone = telefone, CPF = cpf, DataNascimento = datanascimento };

        public override string ToString() => $"Nome: {Nome} | Documento: {CPF} | Data de Nascimento: {DataNascimento} --- Sobrecrita de: { base.ToString()}";

        public bool ValidarSerClienteEMaiorDeIdade() => DateTime.Now.Year - DataNascimento.Year >= 18;       

    }

        
}
