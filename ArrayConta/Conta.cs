using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayConta
{
    public class Conta
    {
        //declaração do atributos
        public int numero;
        public string titular;
        public double saldo;

        // declaração do métodos
        public void Sacar()
        {

        }
        public void Depositar()
        {

        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Número da conta: {numero}\tTitular: {titular}\tSaldo: {saldo:c}");
        }
    }
}