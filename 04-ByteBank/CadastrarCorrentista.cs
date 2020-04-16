using System;
using System.Collections.Generic;
using System.Text;

namespace _04_ByteBank
{
    class CadastrarCorrentista
    {
        ContaCorrente conta = new ContaCorrente();

        public void Cadastro()
        {            
            Console.Write("Insira o nome do titular: ");
            conta.titular = Console.ReadLine();

            Console.Write("Insira a agência: ");
            conta.agencia = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o numero da conta: ");
            conta.numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor inicial da conta: ");
            conta.saldo = double.Parse(Console.ReadLine());
            Console.Clear();
        }
    }
}
