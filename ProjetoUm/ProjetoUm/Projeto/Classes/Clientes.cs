using System;

namespace Projeto.Classes
{
    public class Clientes
    {
        private Clientes()
        { }

        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public long Telefone { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public bool IdadeCliente => ValidarIdadeCliente();

        public bool ValidarIdadeCliente() => DateTime.Now.Year - DataDeNascimento.Year >= 18;

        public static Clientes CreateCliente(string nome, string endereco, long telefone, string cpf, DateTime dataNascimento) =>
        new Clientes { Nome = nome, Endereco = endereco, Telefone = telefone, CPF = cpf, DataDeNascimento = dataNascimento };

        public override string ToString() => $"Nome do cliente: {Nome}  |Endereço: {Endereco}  |Telefone: {Telefone}  |CPF: {CPF}  |Data de Nascimento: {DataDeNascimento}";
    }
}