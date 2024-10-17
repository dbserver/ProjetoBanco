using ProjetoBanco.Domain.Entity.Tipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Domain.Entity.Registro
{
    public class RegistroSaida : Transacao
    {
        public RegistroSaida(int id, decimal valor) : base(id, valor, new TipoSaida())
        {
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine("Transação de Saída");
            base.ExibirDetalhes();
        }
    }
}
