using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticada
{
    // classe cliente implementa a interfaca IAutenticada
    public class Cliente : IAutenticada
    {
        public int Senha { get; set; }

        public bool Autentica(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("Cliente autenticado!");
                return true;
            }
            return false;

        }
    }
}