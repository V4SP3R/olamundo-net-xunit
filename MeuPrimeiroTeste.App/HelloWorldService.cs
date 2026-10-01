using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPrimeiroTeste.App
{
    public class HelloWorldService
    {
        public string GerarSaudacao(String? nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return "Olá, Mundo!";
            }
            return $"Olá {nome}!";
        }
    }
}


