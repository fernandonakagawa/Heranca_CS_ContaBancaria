using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDigital_Heranca
{
    class ContaPoupanca : Conta
    {
        private float _juros;
        public float Juros { get => _juros; private set => _juros = value; }
        public ContaPoupanca(int numeroAgencia, int numeroConta,
            string cpfCliente, float saldo,
            float juros) : base(numeroAgencia, numeroConta, cpfCliente, saldo)
        {
            this.Juros = juros;
        }

        public float PagarJuros(int meses)
        {
            if(this.Saldo > 0)
            {
                float valor = this.Saldo * this.Juros * meses;
                this.Saldo += valor;
                return valor;
            }
            return 0;
        }
    }
}
