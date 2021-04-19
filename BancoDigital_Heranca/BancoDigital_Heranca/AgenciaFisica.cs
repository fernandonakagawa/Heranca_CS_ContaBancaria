using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDigital_Heranca
{
    class AgenciaFisica : Agencia
    {
        private string _endereco;

        public string Endereco { get => _endereco; private set => _endereco = value; }

        public AgenciaFisica(string nome, int numero,
            string endereco):base(nome, numero)
        {
            Endereco = endereco;
        }
    }
}
