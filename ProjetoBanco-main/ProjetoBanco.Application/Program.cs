using ProjetoBanco.Domain.Entity.Extratos;
using ProjetoBanco.Domain.Entity.Registro;
using System;
using System.Collections.Generic;
using ProjetoBanco.Domain.CustomExeception;

namespace ProjetoBanco.Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var extrato = new ExtratoDetalhado(1,"12345", "Marco Vinicius");

                extrato.AdicionarTransacao(new RegistroEntrada(1, 10, extrato));
                extrato.AdicionarTransacao(new RegistroEntrada(2, 10, extrato));
                extrato.AdicionarTransacao(new RegistroEntrada(3, 11, extrato));
                extrato.AdicionarTransacao(new RegistroSaida(4, 10, extrato));
                extrato.AdicionarTransacao(new RegistroSaida(5, 10, extrato));
                extrato.AdicionarTransacao(new RegistroSaida(6, 10, extrato));
                extrato.ImprimirExtrato();

            }
            catch (ExtratoInvalidoException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (ValorInvalidoException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (TipoRegistroInvalidoException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (RegistroSemExtratoException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (TransacaoNaoPermitidaException exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.ReadLine();

        }
    }
}
