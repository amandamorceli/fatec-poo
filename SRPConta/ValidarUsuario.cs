using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRPConta
{
    public class ValidarUsuario 
    {
        public bool ValidaUsuario(string nome)
        {
            return Titular == nome;
        }
    }
}