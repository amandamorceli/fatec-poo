using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticada
{
    public class Gerente : Funcionario, IAutenticada
    {
        public bool Autentica(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("Gerente autenticado!");
                return true;
            }
            return false;

        }
    }
}