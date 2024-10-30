using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe
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

        public void Transferencia(double valorTransferencia, Conta outroObjeto)
        {
            saldo = saldo - valorTransferencia;
            outroObjeto.saldo += valorTransferencia;
        }

    }
}