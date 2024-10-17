using System;


namespace ProjetoBanco.Application.Extrato
{

    public class ExtratoDetalhado : Domain.Entity.Extrato
    {
        public ExtratoDetalhado(int id, string numeroConta, string nomeTitular): base(id,numeroConta,nomeTitular)
        {
           
        }

        public override void ImprimirExtrato()
        {
            var extratoTransacoes = new ExtratoTransacoes();

            foreach(var registro in this.Registros)
            {
                extratoTransacoes.AdicionarTransacao(registro);
            }           

            Console.WriteLine($"Extrato ID: {ID}, Conta: {NumeroConta}, Titular: {NomeTitular}");
            extratoTransacoes.ExibirSaldo();
        }

    }
}
