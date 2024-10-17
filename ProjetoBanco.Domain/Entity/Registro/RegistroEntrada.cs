using ProjetoBanco.Domain.Entity.Tipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Domain.Entity.Registro
{
    public class RegistroEntrada : Transacao
    {
        public RegistroEntrada(int id, decimal valor) : base(id, valor, new TipoEntrada())
        {            
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine("Transação de Entrada");
            base.ExibirDetalhes();
        }
    }

}
