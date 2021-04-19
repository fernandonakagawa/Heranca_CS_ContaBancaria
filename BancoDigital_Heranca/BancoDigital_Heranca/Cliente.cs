namespace BancoDigital_Heranca
{
    class Cliente
    {
        private string _nome;
        private string _cpf;

        public string Nome { get => _nome; private set => _nome = value; }
        public string Cpf { get => _cpf; private set => _cpf = value; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public bool Sacar(Conta c, float valor)
        {
            if (this.Cpf.Equals(c.CpfCliente))
                return c.Retirar(valor);
            return false;
        }
        public bool Depositar(Conta c, float valor)
        {
            if (this.Cpf.Equals(c.CpfCliente))
                return c.Depositar(valor);
            return false;
        }
        public bool Transferir(Conta origem, Conta destino,
            float valor)
        {
            if (this.Cpf.Equals(origem.CpfCliente) &&
                (origem != destino) && valor > 0)
            {
                if (origem.Retirar(valor))
                {
                    return destino.Depositar(valor); ;
                }
            }
            return false;
        }
    }
}