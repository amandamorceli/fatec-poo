using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRPConta
{
    public class GerarRelatórios
    {
        public void GeraRelatórios(string nome, decimal saldo)
        {
            Console.WriteLine($"Titular: {nome}/tCSaldo: {saldo}");
        }
    }
}