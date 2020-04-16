using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaAna = new ContaCorrente();
            ContaCorrente contaDoPedro = new ContaCorrente();
            CadastrarCorrentista cadastrar = new CadastrarCorrentista();

            cadastrar.Cadastro();

            Console.ReadKey();
        }              
    }
}
