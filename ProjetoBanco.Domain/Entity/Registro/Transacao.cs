using ProjetoBanco.Domain.CustomExeception;
using System;
using ProjetoBanco.Domain.Entity.Tipo;

namespace ProjetoBanco.Domain.Entity.Registro
{
    public class Transacao
    {
        public int ID { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataTransacao { get; set; }
        public TipoRegistro Tipo { get; private set; }

        public Transacao(int id, decimal valor, TipoRegistro tipo)
        {
            ID = id;
            Valor = valor;
            DataTransacao = DateTime.Now;
            Tipo = tipo;
        }

        public void ValidarValor()
        {
            if (Valor < 0)
            {
                throw new ValorInvalidoException("O valor do registro não pode ser negativo.");
            }
        }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"ID: {ID}, Valor: {Valor}, Data: {DataTransacao}");
        }
    }
}
