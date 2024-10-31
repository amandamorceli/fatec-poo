using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticada
{
    public class Diretor : Funcionario, IAutenticada
    {
        public bool Autentica(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("Diretor autenticado!");
                return true;
            }
            return false;

        }
    }
}