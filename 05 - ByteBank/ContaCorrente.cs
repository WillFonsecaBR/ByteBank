using System;
using System.Collections.Generic;
using System.Text;

namespace _05___ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular;
        public int agencia;
        public int numero;
        public double saldo;
        
        
        public void depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool sacar(double valor)
        {
            if (valor < this.saldo)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public bool transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.depositar(valor);
                return true;
            }
        }

    }

}






