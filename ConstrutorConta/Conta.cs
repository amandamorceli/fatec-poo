using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        //declaração do atributos
        private int numero;
        private string titular;
        private double saldo;

        public static int contador;

        public static int Contador{
            get {return contador;}
        }

        public Conta()
        {
            contador ++;
            //construtor padrão
        }

        public Conta(int numero)
        {
            this.numero = numero;
            contador ++;
        }
        public Conta(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            contador ++;
        }
        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
            contador ++;

        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Número da conta: {numero}\tTitular: {titular}\tSaldo: {saldo:c}");
        }
    }
}