using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDigital_Heranca
{
    class ClienteEspecial : Cliente
    {
        public ClienteEspecial(string nome, string cpf) : 
            base(nome, cpf)
        {
        }
    }
}
