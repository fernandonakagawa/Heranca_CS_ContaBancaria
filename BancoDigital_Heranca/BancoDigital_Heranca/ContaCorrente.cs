using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDigital_Heranca
{
    class ContaCorrente : Conta
    {
        private float _limiteChequeEspecial;
        private float _jurosChequeEspecial;
        public float LimiteChequeEspecial { get => _limiteChequeEspecial; set => _limiteChequeEspecial = value; }
        public float JurosChequeEspecial { get => _jurosChequeEspecial; set => _jurosChequeEspecial = value; }
        public ContaCorrente(int numeroAgencia, int numeroConta,
            string cpfCliente, float saldo,
            bool isClienteEspecial) : base(numeroAgencia, numeroConta, cpfCliente, saldo)
        {
            if (!isClienteEspecial)
            {
                this.LimiteChequeEspecial = 100f;
                this.JurosChequeEspecial = 0.01f;
            }
            else
            {
                this.LimiteChequeEspecial = 1000f;
                this.JurosChequeEspecial = 0.005f;
            }
        }

        public float CobrarJuros(int dias)
        {
            if(this.Saldo < 0)
            {
                float valor = Math.Abs(this.Saldo);
                valor *= this.JurosChequeEspecial * dias;
                this.Saldo -= valor;
                return valor;
            }
            return 0;
        }
    }
}
