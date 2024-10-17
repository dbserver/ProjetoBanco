using ProjetoBanco.Domain.CustomExeception;
using ProjetoBanco.Domain.Entity.Registro;
using System;
using System.Collections.Generic;

namespace ProjetoBanco.Domain.Entity
{
    public class Extrato
    {
        public int ID { get; set; }
        public string NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        public List<Transacao> Registros { get; private set; }

        public Extrato(int id, string numeroConta, string nomeTitular)
        {
            ID = id;
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Registros = new List<Transacao>();
        }

        public void ValidarNumeroConta()
        {
            if (string.IsNullOrEmpty(NumeroConta))
            {
                throw new ExtratoInvalidoException("O número da conta é inválido.", nameof(NumeroConta));
            }
        }

        public virtual void ImprimirExtrato()
        {
            Console.WriteLine($"Extrato ID: {ID}, Conta: {NumeroConta}");
        }
    }
}
