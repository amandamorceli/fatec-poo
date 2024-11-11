using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRPConta
{
    public class Conta
    {
        public string Titular { get; private set; }
        public decimal Saldo { get; set; }

        public Conta(string titular){
            this.Titular = titular;
            this.Saldo = 0;
        }

        public void Depositar(decimal valor){
            if(valor <= 0)
            {
                Console.WriteLine("Valor de depósito deve ser positivo!");
            }
            this.Saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso!");
        }

        public void Sacar(decimal valor){
            if(valor > this.Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            this.Saldo += valor;
            Console.WriteLine("Saque realizado com sucesso!");
        }
    }
}