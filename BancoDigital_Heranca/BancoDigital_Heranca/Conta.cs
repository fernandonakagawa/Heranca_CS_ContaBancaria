namespace BancoDigital_Heranca
{
    class Conta
    {
        private int _numeroAgencia;
        private int _numeroConta;
        private string _cpfCliente;
        private float _saldo;

        public int NumeroAgencia { get => _numeroAgencia;}
        public int NumeroConta { get => _numeroConta;}
        public string CpfCliente { get => _cpfCliente; }
        public float Saldo { get => _saldo; protected set => _saldo = value; }

        public Conta(int numeroAgencia, int numeroConta, string cpfCliente, float saldo)
        {
            _numeroAgencia = numeroAgencia;
            _numeroConta = numeroConta;
            _cpfCliente = cpfCliente;
            Saldo = saldo;
        }

        public bool Retirar(float valor)
        {
            if(this.Saldo >= valor && valor >= 0)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Depositar(float valor)
        {
            if(valor > 0)
            {
                this.Saldo += valor;
                return true;
            }
            return false;
        }
    }
}