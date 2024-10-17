using ProjetoBanco.Application.Extrato;
using ProjetoBanco.Domain.Entity.Registro;
using System;
using System.Collections.Generic;

namespace ProjetoBanco.Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var extrato = new ExtratoDetalhado(1,"12345", "Marco Vinicius");

            extrato.Registros.Add(new RegistroEntrada(1, 10));
            extrato.Registros.Add(new RegistroEntrada(2, 10));
            extrato.Registros.Add(new RegistroEntrada(3, 11));
            extrato.Registros.Add(new RegistroSaida(4, 10));
            extrato.Registros.Add(new RegistroSaida(5, 10));
            extrato.Registros.Add(new RegistroSaida(6, 10));

            extrato.ImprimirExtrato();


            Console.ReadLine();

        }
    }
}
